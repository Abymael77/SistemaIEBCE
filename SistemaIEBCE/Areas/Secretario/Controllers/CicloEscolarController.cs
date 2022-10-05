using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SistemaIEBCE.AccesoDatos.Data.Repository;
using SistemaIEBCE.Models;
using SistemaIEBCE.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaIEBCE.Areas.Secretario.Controllers
{
    [Authorize(Roles = "Secretario")]
    [Area("Secretario")]
    public class CicloEscolarController : Controller
    {
        private readonly IContenedorTrabajo db;

        public CicloEscolarController(IContenedorTrabajo DbContext)
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
            CicloEscolarVM asigEstVm = new CicloEscolarVM()
            {
                CicloEscolar = new Models.CicloEscolar(),
                ListaGrado = db.Grado.GetListaGrado(),
                ListaSeccion = db.Seccion.GetListaSeccion()
            };
            return View(asigEstVm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CicloEscolarVM CicloEscolarVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.CicloEscolar.Add(CicloEscolarVM.CicloEscolar);
                    db.Save();
                    TempData["error"] = "dodo";
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    TempData["error"] = "Error en validación de modelo.";

                    CicloEscolarVM.ListaGrado = db.Grado.GetListaGrado();
                    CicloEscolarVM.ListaSeccion = db.Seccion.GetListaSeccion();
                    return View(CicloEscolarVM);
                }
            }
            catch (Exception)
            {
                TempData["error"] = "Error de sistema.";
                return View(CicloEscolarVM);
            }
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            try
            {
                CicloEscolarVM asigEstVm = new CicloEscolarVM()
                {
                    CicloEscolar = new Models.CicloEscolar(),
                    ListaGrado = db.Grado.GetListaGrado(),
                    ListaSeccion = db.Seccion.GetListaSeccion(),
                };

                if (id != null)
                {
                    asigEstVm.CicloEscolar = db.CicloEscolar.Get(id.GetValueOrDefault());
                }

                return View(asigEstVm);
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error de sistema.";
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CicloEscolarVM CicloEscolarVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.CicloEscolar.Update(CicloEscolarVM.CicloEscolar);
                    db.Save();
                    TempData["error"] = "dodo";
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    TempData["error"] = "Error en validación de modelo.";

                    CicloEscolarVM.ListaGrado = db.Grado.GetListaGrado();
                    CicloEscolarVM.ListaSeccion = db.Seccion.GetListaSeccion();
                    return View(CicloEscolarVM);
                }
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error de sistema.";
                return View(CicloEscolarVM);
            }
        }


        #region LLAMADAS A LA API
        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new { data = db.CicloEscolar.GetAll(includePropieties: "Grado,Seccion") });
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                var recordDB = db.CicloEscolar.Get(id);
                if (recordDB == null)
                {
                    return Json(new { success = false, message = "Error borrando Ciclo Escolar" });
                }

                db.CicloEscolar.Remove(recordDB);
                db.Save();
                TempData["error"] = "dodo";
                return Json(new { success = true, message = "Ciclo Escolar borrado correctamente" });
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
