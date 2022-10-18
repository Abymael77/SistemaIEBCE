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

namespace SistemaIEBCE.Areas.Director.Controllers
{
    //[Authorize(Roles = "Tesorero")]
    [Area("Tesorero")]
    public class CajaController : Controller
    {
        private readonly IContenedorTrabajo db;

        public CajaController(IContenedorTrabajo DbContext)
        {
            db = DbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Caja caja)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    TempData["error"] = "Error en validación de modelo.";
                    return View(caja);
                }

                var ca = db.Caja.CajaActiva(1);
                Caja cajaEst = new Caja();

                foreach (Caja c in ca)
                {
                    cajaEst.Id = c.Id;
                    cajaEst.Inicio = c.Inicio;
                    cajaEst.Fin = c.Fin;
                    cajaEst.MontoInicial = c.MontoInicial;
                    cajaEst.Estado = c.Estado;
                }

                if (cajaEst.Estado == 1)
                {
                    cajaEst.Estado = 0;
                    if (cajaEst.Fin == null)
                    {
                        cajaEst.Fin = DateTime.Now.Date;
                    }
                    db.Caja.Update(cajaEst);
                    db.Save();
                }

                db.Caja.Add(caja);
                db.Save();
                ViewData["cajaActiva"] = cajaEst;
                HttpContext.Session.SetObject("cajaEst", caja);
                TempData["error"] = "dodo";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                TempData["error"] = "Error de sistema.";
                return View(caja);
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            try
            {
                Caja caja = new Caja();
                caja = db.Caja.Get(id);

                if (caja == null)
                {
                    return NotFound();
                }

                return View(caja);
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error de sistema.";
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Caja caja)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    TempData["error"] = "Error en validacion de modelo.";
                    return View(caja);
                }
                else if (caja.Estado == 1)
                {
                    var ca = db.Caja.CajaActiva(1);
                    Caja cajaEst = new Caja();

                    foreach (Caja c in ca)
                    {
                        cajaEst.Id = c.Id;
                        cajaEst.Inicio = c.Inicio;
                        cajaEst.Fin = c.Fin;
                        cajaEst.MontoInicial = c.MontoInicial;
                        cajaEst.Estado = c.Estado;
                    }

                    if (cajaEst.Estado == 1)
                    {
                        cajaEst.Estado = 0;
                        if (cajaEst.Fin == null)
                        {
                            cajaEst.Fin = DateTime.Now.Date;
                        }
                        db.Caja.Update(cajaEst);
                        db.Save();
                    }
                    ViewData["cajaActiva"] = cajaEst;
                }



                db.Caja.Update(caja);
                db.Save();
                HttpContext.Session.SetObject("cajaEst", caja);
                TempData["error"] = "dodo";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error de sistema.";
                return View(caja);
            }
        }

        [HttpGet]
        public IActionResult CajaDetalle(int idCaja)
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

            IEnumerable<DetalleGasto> dega = db.DetalleGasto.GetAll(filter: hw => hw.IdCaja == cajaEst.Id, includePropieties: "Gasto");
            IEnumerable<DetalleFacturaVM> defavm = db.DetalleFactura.GetListIngresoTipoVM(cajaEst.Id);
            CajaVM ca = new CajaVM()
            {
                Caja = cajaEst,
                DetalleGastoLst = dega,
                DetalleFacturaVM = defavm
            };
            return View(ca);
        }

        [HttpGet]
        public IActionResult CajaDetalleVer(int idCaja)
        {

            Caja caja = db.Caja.GetFirstOrDefault(filter: c => c.Id == idCaja);
            IEnumerable<DetalleGasto> dega = db.DetalleGasto.GetAll(filter: hw => hw.IdCaja == idCaja, includePropieties: "Gasto");
            IEnumerable<DetalleFacturaVM> defavm = db.DetalleFactura.GetListIngresoTipoVM(idCaja);
            CajaVM ca = new CajaVM()
            {
                Caja = caja,
                DetalleGastoLst = dega,
                DetalleFacturaVM = defavm
            };
            return View(ca);
        }

        [HttpGet]
        public IActionResult lsCobros(int idCaja)
        {
            return Json(new { data = db.Caja.GetFirstOrDefault(filter: c => c.Id == idCaja)
            });
        }

        [HttpGet]
        public IActionResult CerrarCaja()
        {
            try
            {
                if (HttpContext.Session.GetObject<Caja>("cajaEst") == null)
                {
                    ViewData["MENSAJE"] = "LA SESSION ESTA VACIA";
                    return RedirectToAction("Create", "Caja");
                }

                Caja caja = HttpContext.Session.GetObject<Caja>("cajaEst");

                if (caja.Estado == 0)
                {
                    return RedirectToAction("Create", "Caja");
                }

                caja.Estado = 0;

                db.Caja.Update(caja);
                db.Save();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error de sistema.";
                return View();
            }
        }


        #region LLAMADAS A LA API
        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new { data = db.Caja.GetAll() });
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                var recordDB = db.Caja.Get(id);
                if (recordDB == null)
                {
                    return Json(new { success = false, message = "Error borrando Caja" });
                }

                db.Caja.Remove(recordDB);
                db.Save();
                TempData["error"] = "dodo";
                return Json(new { success = true, message = "Caja borrado correctamente" });
            }
            catch (Exception)
            {
                TempData["error"] = "Error de sistema.";
                return null;
            }
        }
        #endregion

    }
}
