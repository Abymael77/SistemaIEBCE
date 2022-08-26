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
    [Authorize(Roles = "Director")]
    [Area("Director")]
    public class CatedraticoController : Controller
    {
        private readonly IContenedorTrabajo db;

        public CatedraticoController(IContenedorTrabajo DbContext)
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

        [HttpGet]
        public IActionResult Ver(int id)
        {
            try
            {
                Catedratico catedratico = new Catedratico();
                catedratico = db.Catedratico.Get(id);

                if (catedratico == null)
                {
                    return NotFound();
                }

                return View(catedratico);
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error de sistema.";
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Catedratico catedratico)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    TempData["error"] = "Error en validación de modelo.";
                    return View(catedratico);
                }

                db.Catedratico.Add(catedratico);
                db.Save();
                TempData["error"] = "dodo";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                TempData["error"] = "Error de sistema.";
                return View(catedratico);
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            try
            {
                Catedratico catedratico = new Catedratico();
                catedratico = db.Catedratico.Get(id);

                if (catedratico == null)
                {
                    return NotFound();
                }

                return View(catedratico);
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error de sistema.";
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Catedratico catedratico)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    TempData["error"] = "Error en validacion de modelo.";
                    return View(catedratico);
                }

                db.Catedratico.Update(catedratico);
                db.Save();
                TempData["error"] = "dodo";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error de sistema.";
                return View(catedratico);
            }
        }


        #region LLAMADAS A LA API
        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new { data = db.Catedratico.GetAll() });
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                var recordDB = db.Catedratico.Get(id);
                if (recordDB == null)
                {
                    return Json(new { success = false, message = "Error borrando Catedratico" });
                }

                db.Catedratico.Remove(recordDB);
                db.Save();
                TempData["error"] = "dodo";
                return Json(new { success = true, message = "Catedratico borrado correctamente" });
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
