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
    [Authorize(Roles ="Director")]
    [Area("Director")]
    public class AdminController : Controller
    {
        private readonly IContenedorTrabajo db;

        //public NotaController(IContenedorTrabajo DbContext)
        //{
        //    db = DbContext;
        //}

        public AdminController( IContenedorTrabajo _db)
        {
            db = _db;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult BloqueAsigCurso()
        {
            BloqueAsigCursoVM bacvm = new BloqueAsigCursoVM()
            {
                BloqueAsigCurso = new Models.BloqueAsigCurso(),
                ListaBloque = db.Bloque.GetListaBloqueEstado(1),
                ListaBloqueCrear = db.Bloque.GetListaBloque()
            };

            return View(bacvm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult BloqueAsigCurso(BloqueAsigCursoVM bloqueAsigCursoVM)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    TempData["error"] = "Error en validación de modelo.";
                    return View(bloqueAsigCursoVM);
                }

                int id = bloqueAsigCursoVM.BloqueAsigCurso.IdBloque;
                int estado = bloqueAsigCursoVM.BloqueAsigCurso.Estado;

                var js = Json(new
                {
                    data = db.AsigCurso.GetListaAsigCursoEst(estado),
                });

                //db.BloqueAsigCurso.Add(bloqueAsigCursoVM.BloqueAsigCurso);
                //db.Save();
                TempData["error"] = "dodo";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                TempData["error"] = "Error de sistema.";
                return View(bloqueAsigCursoVM);
            }
        }
    }
}