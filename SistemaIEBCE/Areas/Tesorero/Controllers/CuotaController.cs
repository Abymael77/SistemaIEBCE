using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SistemaIEBCE.AccesoDatos.Data.Repository;
using SistemaIEBCE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaIEBCE.Areas.Director.Controllers
{
    [Authorize(Roles = "Tesorero")]
    [Area("Tesorero")]
    public class CuotaController : Controller
    {
        private readonly IContenedorTrabajo db;

        public CuotaController(IContenedorTrabajo DbContext)
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
        public IActionResult Create(Cuota cuota)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    TempData["error"] = "Error en validación de modelo.";
                    return View(cuota);
                }

                db.Cuota.Add(cuota);
                db.Save();
                TempData["error"] = "dodo";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                TempData["error"] = "Error de sistema.";
                return View(cuota);
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            try
            {
                Cuota cuota = new Cuota();
                cuota = db.Cuota.Get(id);

                if (cuota == null)
                {
                    return NotFound();
                }

                return View(cuota);
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error de sistema.";
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Cuota cuota)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    TempData["error"] = "Error en validacion de modelo.";
                    return View(cuota);
                }

                db.Cuota.Update(cuota);
                db.Save();
                TempData["error"] = "dodo";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error de sistema.";
                return View(cuota);
            }
        }


        #region LLAMADAS A LA API
        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new { data = db.Cuota.GetAll() });
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                var recordDB = db.Cuota.Get(id);
                if (recordDB == null)
                {
                    return Json(new { success = false, message = "Error borrando Cuota" });
                }

                db.Cuota.Remove(recordDB);
                db.Save();
                TempData["error"] = "dodo";
                return Json(new { success = true, message = "Cuota borrado correctamente" });
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
