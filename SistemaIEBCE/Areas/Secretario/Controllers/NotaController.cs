using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using SistemaIEBCE.AccesoDatos.Data.Repository;
using SistemaIEBCE.Models;
using SistemaIEBCE.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaIEBCE.Areas.Secretario.Controllers
{
    //[Authorize(Roles = "Secretario")]
    [Area("Secretario")]
    public class NotaController : Controller
    {
        private readonly IContenedorTrabajo db;
        private readonly IConfiguration configuration;

        //public NotaController(IContenedorTrabajo DbContext)
        //{
        //    db = DbContext;
        //}
        
        public NotaController(IConfiguration _configuration, IContenedorTrabajo _db)
        {
            configuration = _configuration;
            db = _db;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Curso(int? IdCicloEscolar)
        {//id = IdCicloEscolar
            try
            {
                if (IdCicloEscolar == null)
                {
                    return RedirectToAction("Error?StatusCode=404", "Menu", "Invitado");
                }
                var conn = configuration.GetValue<string>("ConnectionStrings:conSQL2");
                SqlDataAdapter da = new SqlDataAdapter("SELECT AsCu.Id, Cur.NomCurso, Cat.NomCatedratico, Cat.ApellCatedratico FROM AsigCurso AS AsCu INNER JOIN Curso As Cur ON AsCu.IdCurso = Cur.Id INNER JOIN Catedratico AS Cat ON AsCu.IdCatedratico = Cat.Id WHERE AsCu.IdCicloEscolar = " + IdCicloEscolar, conn);

                DataTable dt = new DataTable();

                da.Fill(dt);
                ViewData["IdCicloEscolar"] = IdCicloEscolar;

                //return tabla de cursos
                return View(dt);
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error de sistema.";
                return View();
            }
        }

        [HttpGet]
        public IActionResult Bloque(int? id, int? IdCicloEscolar)
        {//id = IdAsigCurso

            if (id == null || IdCicloEscolar == null)
            {
                return RedirectToAction("Error?StatusCode=404", "Menu", "Invitado");
            }
            ViewData["asigcur"] = id;
            ViewData["IdCicloEscolar"] = IdCicloEscolar;

            return View();
        }


        [HttpGet]
        public IActionResult CreateBloqueAsigCurso(int? id, int? IdCicloEscolar)
        {
            if (id == null || IdCicloEscolar == null)
            {
                return RedirectToAction("Error?StatusCode=404", "Menu", "Invitado");
            }

            ViewData["asig"] = id;
            ViewData["IdCicloEscolar"] = IdCicloEscolar;


            var conn = configuration.GetValue<string>("ConnectionStrings:conSQL2");
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Bloque WHERE Estado = 1", conn);

            //DataTable dad = new BloqueAsigCursoVM().DataTable;

            DataTable dt = new DataTable();

            da.Fill(dt);

            ViewData["blk"] = dt;

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
        public IActionResult CreateBloqueAsigCurso(BloqueAsigCursoVM bloqueAsigCursoVM)
        {
            ViewData["asig"] = bloqueAsigCursoVM.BloqueAsigCurso.IdAsigCurso;
            ViewData["IdCicloEscolar"] = bloqueAsigCursoVM.BloqueAsigCurso.Estado;

            try
            {
                if (ModelState.IsValid)
                {
                    //asignar 1 al estado que se uso como idCicloEsc
                    bloqueAsigCursoVM.BloqueAsigCurso.Estado = 1;


                    BloqueAsigCurso blascu = new BloqueAsigCurso();
                    blascu.Estado = bloqueAsigCursoVM.BloqueAsigCurso.Estado;
                    blascu.IdBloque = bloqueAsigCursoVM.BloqueAsigCurso.IdBloque;
                    blascu.IdAsigCurso = bloqueAsigCursoVM.BloqueAsigCurso.IdAsigCurso;

                    db.BloqueAsigCurso.Add(blascu);
                    db.Save();

                    //asignar las notas a los estudiante existendes del nuevo bloque en un curso

                    var idBlAsCu = "SELECT TOP 1 ascu.IdCicloEscolar, blascu.Id FROM BloqueAsigCurso AS blascu INNER JOIN AsigCurso AS ascu ON ascu.Id = blascu.IdAsigCurso ORDER BY blascu.Id DESC ";

                    var conn = configuration.GetValue<string>("ConnectionStrings:conSQL2");
                    SqlDataAdapter dabl = new SqlDataAdapter(idBlAsCu, conn);

                    DataTable dtBlAsCu = new DataTable();
                    dabl.Fill(dtBlAsCu);

                    var LsAsEs = "SELECT ases.Id FROM AsigEstudiante AS ases INNER JOIN Estudiante AS es ON es.Id = ases.IdEstudiante WHERE ases.IdCicloEscolar = " + dtBlAsCu.Rows[0]["IdCicloEscolar"].ToString();
                    SqlDataAdapter daLs = new SqlDataAdapter(LsAsEs, conn);

                    DataTable dtLsAsEs = new DataTable();
                    daLs.Fill(dtLsAsEs);

                    Nota nota = new Nota();

                    foreach (DataRow item in dtLsAsEs.Rows)
                    {
                        var ins = "-> " + item["Id"] + " -> " + dtBlAsCu.Rows[0]["IdCicloEscolar"].ToString();

                        nota.Id = null;
                        nota.Punteo = 0;
                        nota.IdAsigEstudinate = (int)item["Id"];
                        nota.IdBloqueAsigCurso = (int)dtBlAsCu.Rows[0]["Id"];


                        db.Nota.Add(nota);
                        db.Save();
                    }

                    TempData["error"] = "dodo";
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    TempData["error"] = "Error en validación de modelo.";
                    bloqueAsigCursoVM.ListaBloque = db.Bloque.GetListaBloqueEstado(1);
                    bloqueAsigCursoVM.ListaBloqueCrear = db.Bloque.GetListaBloque();
                    return View(bloqueAsigCursoVM);

                }
            }
            catch (Exception)
            {
                TempData["error"] = "Error de sistema.";
                bloqueAsigCursoVM.ListaBloque = db.Bloque.GetListaBloqueEstado(1);
                bloqueAsigCursoVM.ListaBloqueCrear = db.Bloque.GetListaBloque();
                return View(bloqueAsigCursoVM);
            }
        }

        //ListEstudiante
        [HttpGet]
        public IActionResult ListEstudiante(int? IdBlkAsCu, int IdCicloEscolar, int IdAsigCurso)
        {
            if (IdBlkAsCu == null || IdCicloEscolar.ToString() == null  || IdAsigCurso.ToString() == null)
            {
                return RedirectToAction("Error?StatusCode=404", "Menu", "Invitado");
            }
            //ViewBag.IdBlkAsCu = IdBlkAsCu;
            //ViewBag.IdCicloEscolar = IdCicloEscolar;
            //ViewBag.IdAsigCurso = IdAsigCurso;
            ViewData["idBlkAsCu"] = IdBlkAsCu;
            ViewData["IdCicloEscolar"] = IdCicloEscolar;
            ViewData["IdAsigCurso"] = IdAsigCurso;


            return View();
        }

        [HttpGet]
        public IActionResult ListEstudianteLS(int? IdBlkAsCu, int? est, int IdCicloEscolar, int IdAsigCurso)
        {
            if (IdBlkAsCu == null || est == null)
            {
                return RedirectToAction("Error?StatusCode=404", "Menu", "Invitado");
            }
            ViewData["Estado"] = est;

            int idCicloEsc = 0;

            List<BloqueAsigCurso> blascu = (List<BloqueAsigCurso>)db.BloqueAsigCurso.GetListaBloqueCurso(IdBlkAsCu);

            foreach (BloqueAsigCurso item in blascu)
            {
                idCicloEsc = item.AsigCurso.IdCicloEscolar;
            }

            return Json(new
            {
                data = db.AsigEstudiante.GetListaAsigEstudianteCiclo(IdBlkAsCu, est, IdCicloEscolar, IdAsigCurso),
            }
            );
        }

        [HttpGet]
        public IActionResult ListNota(int? IdBlkAsCu, int? est)
        {
            if (IdBlkAsCu == null || est == null)
            {
                return RedirectToAction("Error?StatusCode=404", "Menu", "Invitado");
            }

            ViewData["Estado"] = est;

            int idCicloEsc = 0;

            List<BloqueAsigCurso> blascu = (List<BloqueAsigCurso>)db.BloqueAsigCurso.GetListaBloqueCurso(IdBlkAsCu);

            foreach (BloqueAsigCurso item in blascu)
            {
                idCicloEsc = item.AsigCurso.IdCicloEscolar;
            }

            return Json(new
            {
                data = db.AsigEstudiante.GetListaNota(idCicloEsc, est),
            }
            );
        }

        [HttpPost]
        public IActionResult SaveNota(string[] ListaEstNota1, string[] ListaIdEst1, string[] ListaIdNt1, int IdBlkAsCu1)
        {
            Nota nota = new Nota();

            //hay que valiar que las notas no sean nullas aqui da un error de vez en cuando

            var ListConcat = ListaIdEst1.Zip(ListaEstNota1, (ides, nt) => new { IdAsigEstudinate = ides, Punteo = nt});

            DataTable NotaAll = new DataTable();
            NotaAll.Columns.Add("Id", typeof(int));
            NotaAll.Columns.Add("IdAsigEstudinate", typeof(int));
            NotaAll.Columns.Add("IdBloqueAsigCurso", typeof(int));
            NotaAll.Columns.Add("Punteo", typeof(int));

            foreach (var item in ListConcat)
            {
                if (item.Punteo == null)
                {
                    var punt = 0;
                    NotaAll.Rows.Add(new Object[] {
                    0,
                    item.IdAsigEstudinate,
                    IdBlkAsCu1,
                    punt
                    });
                }
                else
                {
                    NotaAll.Rows.Add(new Object[] {
                    0,
                    item.IdAsigEstudinate,
                    IdBlkAsCu1,
                    item.Punteo
                    });
                }
                
            }

            for (int i = 0; i < NotaAll.Rows.Count; i++)
            {
                nota.Id = Convert.ToInt32(ListaIdNt1[i]); //No debe ser NULL
                nota.IdAsigEstudinate = Convert.ToInt32(NotaAll.Rows[i]["IdAsigEstudinate"]);
                nota.IdBloqueAsigCurso = Convert.ToInt32(NotaAll.Rows[i]["IdBloqueAsigCurso"]);
                nota.Punteo = Convert.ToInt32(NotaAll.Rows[i]["Punteo"]);

                db.Nota.Update(nota);
                db.Save();
            }

            ViewData["nall"] = NotaAll;
            ViewData["save"] = nota;
            TempData["error"] = "dodo";

            return View(nota);

        }

        public IActionResult Boleta(int idAsigEstudinate, int IdBloque)
        {
            ViewData["idBloque"] = IdBloque;
            ViewData["idAsigEstudinate"] = idAsigEstudinate;
            TempData["idBloque"] = IdBloque;
            TempData["idAsigEstudinate"] = idAsigEstudinate;
            return View();
        }

        [HttpGet]
        public IActionResult ListNotaCurso(int idAsigEstudinate, int idBloque)
        {

            ViewData["idAsigEstudinate"] = idAsigEstudinate;

            //idAsigEstudinate = (int)TempData["idAsigEstudinate"];
           // idBloque = (int)TempData["idBloque"];


            return Json(new
            {
                data = db.AsigEstudiante.GetListaNotaBlk(idAsigEstudinate, idBloque)
            }
            );
        }

        #region
            [HttpGet]
            public IActionResult GetAll(int id)
            {//id = IdAsigCurso
                return Json(new
                {
                    data = db.BloqueAsigCurso.GetListaBloqueAsCu(id)
                }
                );
            }
        #endregion

    }
}
