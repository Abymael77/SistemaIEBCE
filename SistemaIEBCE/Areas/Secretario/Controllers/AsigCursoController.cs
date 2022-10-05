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
    public class AsigCursoController : Controller
    {
        private readonly IContenedorTrabajo db;

        public AsigCursoController(IContenedorTrabajo DbContext)
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
            AsigCursoVM asigEstVm = new AsigCursoVM()
            {
                AsigCurso = new Models.AsigCurso(),
                ListaCatedratico = db.Catedratico.GetListaCatedratico(),
                ListaCurso = db.Curso.GetListaCurso(),
                ListaCicloEscolar = db.AsigCurso.GetListaAsigCicloEscolar()
            };
            return View(asigEstVm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(AsigCursoVM AsigCursoVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.AsigCurso.Add(AsigCursoVM.AsigCurso);
                    db.Save();
                    TempData["error"] = "dodo";
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    TempData["error"] = "Error en validación de modelo.";

                    AsigCursoVM.ListaCatedratico = db.Catedratico.GetListaCatedratico();
                    AsigCursoVM.ListaCurso = db.Curso.GetListaCurso();
                    AsigCursoVM.ListaCicloEscolar = db.AsigCurso.GetListaAsigCicloEscolar();
                    return View(AsigCursoVM);
                }
            }
            catch (Exception)
            {
                TempData["error"] = "Error de sistema.";
                AsigCursoVM.ListaCatedratico = db.Catedratico.GetListaCatedratico();
                AsigCursoVM.ListaCurso = db.Curso.GetListaCurso();
                AsigCursoVM.ListaCicloEscolar = db.AsigCurso.GetListaAsigCicloEscolar();
                return View(AsigCursoVM);
            }
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            try
            {
                AsigCursoVM asigEstVm = new AsigCursoVM()
                {
                    AsigCurso = new Models.AsigCurso(),
                    ListaCatedratico = db.Catedratico.GetListaCatedratico(),
                    ListaCurso = db.Curso.GetListaCurso(),
                    ListaCicloEscolar = db.AsigCurso.GetListaAsigCicloEscolar(),
                };

                if (id != null)
                {
                    asigEstVm.AsigCurso = db.AsigCurso.Get(id.GetValueOrDefault());
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
        public IActionResult Edit(AsigCursoVM AsigCursoVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.AsigCurso.Update(AsigCursoVM.AsigCurso);
                    db.Save();
                    TempData["error"] = "dodo";
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    TempData["error"] = "Error en validación de modelo.";

                    AsigCursoVM.ListaCatedratico = db.Catedratico.GetListaCatedratico();
                    AsigCursoVM.ListaCurso = db.Curso.GetListaCurso();
                    AsigCursoVM.ListaCicloEscolar = db.AsigCurso.GetListaAsigCicloEscolar();
                    return View(AsigCursoVM);
                }
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error de sistema.";
                return View(AsigCursoVM);
            }
        }


        #region LLAMADAS A LA API
        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new { data = db.AsigCurso.GetAll(includePropieties: "Catedratico,Curso,CicloEscolar"),
                                //data1 = db.Grado.GetAll(includePropieties: "Grado"),
                                //data2 = db.Seccion.GetAll(includePropieties: "Seccion")
                            }
            );
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                var recordDB = db.AsigCurso.Get(id);
                if (recordDB == null)
                {
                    return Json(new { success = false, message = "Error borrando Ciclo Escolar" });
                }

                db.AsigCurso.Remove(recordDB);
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
