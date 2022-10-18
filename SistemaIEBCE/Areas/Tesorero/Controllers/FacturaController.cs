using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SistemaIEBCE.AccesoDatos.Data.Repository;
using SistemaIEBCE.Models;
using SistemaIEBCE.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Http;
using SistemaIEBCE.Extensions;
using System.Data;

namespace SistemaIEBCE.Areas.Director.Controllers
{
    //[Authorize(Roles = "Tesorero")]
    [Area("Tesorero")]
    public class FacturaController : Controller
    {
        private readonly IContenedorTrabajo db;

        public FacturaController(IContenedorTrabajo DbContext)
        {
            db = DbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            if (HttpContext.Session.GetObject<Caja>("cajaEst") == null)
            {
                ViewData["MENSAJE"] = "LA SESSION ESTA VACIA";
                return RedirectToAction("Create", "Caja");
            }

            Caja cajaEst = HttpContext.Session.GetObject<Caja>("cajaEst");

            if (cajaEst.Estado == 0)
            {
                return RedirectToAction("Create", "Caja");
            }
            
            IEnumerable<Cuota> cuotas = db.Cuota.GetAll(filter: ct => ct.Estado == 1);

            IEnumerable<AsigEstudiante> asigEstudiante = db.AsigEstudiante.GetAll(filter: hw => hw.Estado == 1, includePropieties: "Estudiante,CicloEscolar");

            FacturaVM facturaVM = new FacturaVM()
            {
                Factura = new Models.Factura(),
                Caja = cajaEst,
                Cuotas = cuotas,
                AsigEstudiantes = asigEstudiante
            };

            ViewData["Cuotas"] = Json(new { data = db.Cuota.GetAll(filter: ct => ct.Estado == 1) });

            //session de id asigEstudiante = 0
            HttpContext.Session.SetInt32("ases", 0);

            return View(facturaVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(CajaVM cajaVM)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    Caja cajaEst = HttpContext.Session.GetObject<Caja>("cajaEst");
                    IEnumerable<Gasto> gast = db.Gasto.GetAll();
                    CajaVM cajaVMRet = new CajaVM()
                    {
                        Factura = new Models.Factura(),
                        DetalleFactura = new Models.DetalleFactura(),
                        Caja = cajaEst,
                    };
                    TempData["error"] = "Error en validación de modelo.";
                    return View(cajaVMRet);
                }

                db.Factura.Add(cajaVM.Factura);
                db.Save();
                TempData["error"] = "dodo";
                return RedirectToAction("Index", "Menu");
            }
            catch (Exception)
            {
                Caja cajaEst = HttpContext.Session.GetObject<Caja>("cajaEst");
                IEnumerable<Cuota> cuotas = db.Cuota.GetAll();
                CajaVM cajaVMRet = new CajaVM()
                {
                    DetalleGasto = new Models.DetalleGasto(),
                    Caja = cajaEst,
                    Cuotas = cuotas
                };
                TempData["error"] = "Error de sistema.";
                return View(cajaVMRet);
            }
        }


        [HttpPost]
        public IActionResult SaveDetalleFactura(string[] ListaCuota1, string[] ListaCantidad1, float[] ListaMonto1, int idAsEs1, string fecha, int noRecibo)
        {
            DetalleFactura  detalleFactura = new DetalleFactura();

            //factura
            Caja cajaEst = HttpContext.Session.GetObject<Caja>("cajaEst");
            Factura factura = new Factura();
            factura.IdAsigEstudiante = idAsEs1;
            factura.IdCaja = cajaEst.Id;
            factura.NoFactura = noRecibo;
            factura.Fecha = Convert.ToDateTime(fecha);
            //guardar factura
            db.Factura.Add(factura);
            db.Save();

            //obtener factura
            Factura nuevaFactura = db.Factura.GetFacturaUltimo();


            var ListConcat = ListaCuota1.Zip(ListaCantidad1, (iiCu, cant) => new { IdCuota = iiCu, Cantidad = cant });

            DataTable DetFacturaAll = new DataTable();
            DetFacturaAll.Columns.Add("Id", typeof(int));
            DetFacturaAll.Columns.Add("IdCuota", typeof(int));
            DetFacturaAll.Columns.Add("IdFactura", typeof(int));
            DetFacturaAll.Columns.Add("Monto", typeof(decimal));
            DetFacturaAll.Columns.Add("Cantidad", typeof(int));

            foreach (var item in ListConcat)
            {
                if (item.Cantidad == null)
                {
                    DetFacturaAll.Rows.Add(new Object[] {
                    null,
                    item.IdCuota,
                    0, 
                    0,
                    0
                    });
                }
                else
                {
                    DetFacturaAll.Rows.Add(new Object[] {
                    null,
                    item.IdCuota,
                    0,
                    0,
                    item.Cantidad
                    });
                }

            }

            //falta crear la factura y obtener el id de la factuira para asignarlo a detalle

            for (int i = 0; i < DetFacturaAll.Rows.Count; i++)
            {
                detalleFactura.Id = null; //No debe ser NULL
                detalleFactura.IdCuota = Convert.ToInt32(DetFacturaAll.Rows[i]["IdCuota"]);
                detalleFactura.IdFactura = nuevaFactura.Id;
                detalleFactura.Monto = ListaMonto1[i];
                detalleFactura.Cantidad = Convert.ToInt32(DetFacturaAll.Rows[i]["Cantidad"]);

                db.DetalleFactura.Add(detalleFactura);
                db.Save();
            }


            return RedirectToAction("Index", "Menu");

        }


        #region Consultas para relllenar formulario de factura
        [HttpGet]
        public IActionResult GetCiloEscEstu(int idCicEsc, int idAsEs)
        {
            
            //hay que mantener un solo idAsigEstudiante por ahora se guardan todos los seleccionados con aterioridad
            //solo hay que guardadr 1
            ViewData["asigEstudiante"] = idAsEs;
            HttpContext.Session.SetInt32("ases", idAsEs);

            return Json(new { data = db.CicloEscolar.GetAll(filter: ces => ces.Id == idCicEsc, includePropieties: "Seccion,Grado"),
                                idAsEs = idAsEs});
        }

        [HttpGet]
        public IActionResult GetPagoRealizado(int idAsEs)
        {
            return Json(new { lstCuotas = db.Cuota.GetAll(),
                lstPagado = db.DetalleFactura.GetPagoRealizado(idAsEs)
            });
        }

        [HttpGet]
        public IActionResult GetCuota()
        {
            return Json(new { data = db.Cuota.GetAll(filter: ct => ct.Estado == 1)});
        }

        [HttpGet]
        public IActionResult GetCuotaMt(int idCuota)
        {
            return Json(new { data = db.Cuota.GetAll(filter: ct => ct.Id == idCuota)});
        }
        #endregion


    }
}