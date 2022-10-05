using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SistemaIEBCE.AccesoDatos.Data.Repository;
using SistemaIEBCE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaIEBCE.Areas.Secretario.Controllers
{
    [Authorize(Roles = "Secretario")]
    [Area("Secretario")]
    public class EstudianteController : Controller
    {
        private readonly IContenedorTrabajo db;

        public EstudianteController(IContenedorTrabajo DbContext)
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
                Estudiante estudiante = new Estudiante();
                estudiante = db.Estudiante.Get(id);

                if (estudiante == null)
                {
                    return NotFound();
                }

                return View(estudiante);
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error de sistema.";
                return View();
            }
        }
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Estudiante estudiante)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    TempData["error"] = "Error en validación de modelo.";
                    return View(estudiante);
                }

                db.Estudiante.Add(estudiante);
                db.Save();
                TempData["error"] = "dodo";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                TempData["error"] = "Error de sistema.";
                return View(estudiante);
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            try
            {
                Estudiante estudiante = new Estudiante();
                estudiante = db.Estudiante.Get(id);

                if (estudiante == null)
                {
                    return NotFound();
                }

                return View(estudiante);
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error de sistema.";
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Estudiante estudiante)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    TempData["error"] = "Error en validacion de modelo.";
                    return View(estudiante);
                }

                db.Estudiante.Update(estudiante);
                db.Save();
                TempData["error"] = "dodo";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error de sistema.";
                return View(estudiante);
            }
        }


        #region LLAMADAS A LA API
        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new { data = db.Estudiante.GetAll() });
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                var recordDB = db.Estudiante.Get(id);
                if (recordDB == null)
                {
                    return Json(new { success = false, message = "Error borrando Estudiante" });
                }

                db.Estudiante.Remove(recordDB);
                db.Save();
                TempData["error"] = "dodo";
                return Json(new { success = true, message = "Estudiante borrado correctamente" });
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
