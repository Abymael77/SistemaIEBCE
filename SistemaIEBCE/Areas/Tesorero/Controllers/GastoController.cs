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
    [Authorize(Roles = "Tesorero,Director")]
    [Area("Tesorero")]
    public class GastoController : Controller
    {
        private readonly IContenedorTrabajo db;

        public GastoController(IContenedorTrabajo DbContext)
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
        public IActionResult Create(Gasto gasto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    TempData["error"] = "Error en validación de modelo.";
                    return View(gasto);
                }

                db.Gasto.Add(gasto);
                db.Save();
                TempData["error"] = "dodo";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                TempData["error"] = "Error de sistema.";
                return View(gasto);
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            try
            {
                Gasto gasto = new Gasto();
                gasto = db.Gasto.Get(id);

                if (gasto == null)
                {
                    return NotFound();
                }

                return View(gasto);
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error de sistema.";
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Gasto gasto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    TempData["error"] = "Error en validacion de modelo.";
                    return View(gasto);
                }

                db.Gasto.Update(gasto);
                db.Save();
                TempData["error"] = "dodo";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error de sistema.";
                return View(gasto);
            }
        }


        #region LLAMADAS A LA API
        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new { data = db.Gasto.GetAll() });
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                var recordDB = db.Gasto.Get(id);
                if (recordDB == null)
                {
                    return Json(new { success = false, message = "Error borrando Gasto" });
                }

                db.Gasto.Remove(recordDB);
                db.Save();
                TempData["error"] = "dodo";
                return Json(new { success = true, message = "Gasto borrado correctamente" });
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
