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
    [Authorize(Roles = "Tesorero,Director")]
    [Area("Tesorero")]
    public class DetalleGastoController : Controller
    {
        private readonly IContenedorTrabajo db;

        public DetalleGastoController(IContenedorTrabajo DbContext)
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

            IEnumerable<Gasto> gast = db.Gasto.GetAll();


            CajaVM cajaVM = new CajaVM()
            {
                DetalleGasto = new Models.DetalleGasto(),
                Caja = cajaEst,
                Gastos = gast
            };

            return View(cajaVM);
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
                        DetalleGasto = new Models.DetalleGasto(),
                        Caja = cajaEst,
                        Gastos = gast
                    };
                    TempData["error"] = "Error en validación de modelo.";
                    return View(cajaVMRet);
                }

                db.DetalleGasto.Add(cajaVM.DetalleGasto);
                db.Save();
                TempData["error"] = "dodo";
                return RedirectToAction("Index", "Menu");
            }
            catch (Exception)
            {
                Caja cajaEst = HttpContext.Session.GetObject<Caja>("cajaEst");
                IEnumerable<Gasto> gast = db.Gasto.GetAll();
                CajaVM cajaVMRet = new CajaVM()
                {
                    DetalleGasto = new Models.DetalleGasto(),
                    Caja = cajaEst,
                    Gastos = gast
                };
                TempData["error"] = "Error de sistema.";
                return View(cajaVMRet);
            }
        }

    }
}
