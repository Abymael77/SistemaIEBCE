using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SistemaIEBCE.AccesoDatos.Data.Repository;
using SistemaIEBCE.Models;
using SistemaIEBCE.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaIEBCE.Areas.Director.Controllers
{
    [Authorize(Roles = "Tesorero")]
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

                //debo obtener la caja con estado 1 en la Bd
                CajaVM cajaEst = new CajaVM()
                { 
                    Caja = (Caja)db.Caja.CajaActiva(1)
                };

                //if(cajaEst.Estado == 1)
                //{
                //    cajaEst.Estado = 0;
                //    //db.Caja.Update(cajaEst);
                //    //db.Save();
                //}

                //db.Caja.Add(caja);
                //db.Save();
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

                Caja cajaEst = new Caja();
                cajaEst = (Caja)db.Caja.CajaActiva(1);
                if (caja.Estado == 1 && cajaEst.Estado == 1)
                {
                    cajaEst.Estado = 0;
                    //db.Caja.Update(cajaEst);
                    //db.Save();
                }

                //db.Caja.Update(caja);
                //db.Save();
                TempData["error"] = "dodo";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error de sistema.";
                return View(caja);
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
