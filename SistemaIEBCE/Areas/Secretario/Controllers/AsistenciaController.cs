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
    public class AsistenciaController : Controller
    {
        private readonly IContenedorTrabajo db;
        private readonly IConfiguration configuration;

        //public NotaController(IContenedorTrabajo DbContext)
        //{
        //    db = DbContext;
        //}
        
        public AsistenciaController(IConfiguration _configuration, IContenedorTrabajo _db)
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
            ViewData["asigcur"] = id;
            ViewData["IdCicloEscolar"] = IdCicloEscolar;

            return View();
        }

        [HttpGet]
        public IActionResult GetAll(int id)
        {//id = IdAsigCurso
            return Json(new
            {
                data = db.BloqueAsigCurso.GetListaBloqueAsCu(id)
            }
            );
        }


        //####################################################################################################
        //
        //  Ahora falta listar las asistencias existentes por bloque en una tabla 
        //  y la opcion de agregar nueva asistencia en donde se van a listar los estudiantes
        //  para asignar el tipo de aistencia.
        //
        //####################################################################################################
        [HttpGet]
        public IActionResult TblAsistencia(int IdBlkAsCu, int IdCicloEscolar, int IdAsigCurso)
        {
            ViewData["IdBlkAsCu"] = IdBlkAsCu;
            ViewData["IdCicloEscolar"] = IdCicloEscolar;
            ViewData["IdAsigCurso"] = IdAsigCurso;


            var conn = configuration.GetValue<string>("ConnectionStrings:conSQL2");
            SqlDataAdapter da = new SqlDataAdapter("SELECT asis.IdBloqueAsigCurso, asis.Fecha FROM Asistencia As asis WHERE asis.IdBloqueAsigCurso = " + IdBlkAsCu + " GROUP BY asis.Fecha, asis.IdBloqueAsigCurso", conn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return View(dt);
        }







        [HttpGet]
        public IActionResult UpdateAsis(int IdBlkAsCu, int IdCicloEscolar, string Fecha)
        {
            ViewData["IdBlkAsCu"] = IdBlkAsCu;
            ViewData["IdCicloEscolar"] = IdCicloEscolar;
            //ViewData["Fecha"] = Fecha;

            Fecha = Convert.ToDateTime(Fecha).ToString("dd/MM/yyyy");

            var conn = configuration.GetValue<string>("ConnectionStrings:conSQL2");
            SqlDataAdapter da = new SqlDataAdapter("SELECT asis.Id, asis.Fecha, asis.Tipo, asis.Comentario, asis.IdAsigEstudinate, es.NomEstudiante, es.ApellEstudiante FROM Asistencia As asis INNER JOIN AsigEstudiante AS ases ON ases.Id = asis.IdAsigEstudinate INNER JOIN Estudiante AS es ON es.Id = ases.IdEstudiante WHERE asis.IdBloqueAsigCurso = " + IdBlkAsCu + " AND asis.Fecha = CONVERT(DATE,'" + Fecha + "', 104)", conn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            
            //ViewData["Fecha"] = String.Join("-", Fecha.Split('/').Reverse());
            ViewData["Fecha"] = Convert.ToDateTime(Fecha).ToString("yyyy-MM-dd");

            return View(dt);
        }

        [HttpPost]
        public IActionResult UpdateAsistencia(string[] ListaIdAsis1, string[] ListaAsEs1, string[] ListaTipo1, string[] ListaComent1, int IdBlkAsCu1, string fecha1)
        {
            Asistencia asistencia = new Asistencia();
            fecha1 = Convert.ToDateTime(fecha1).ToString("dd/MM/yyyy");

            var ListConcat = ListaAsEs1.Zip(ListaTipo1, (ides, tpas) => new { IdAsigEstudinate = ides, Tipo = tpas });

            DataTable AsistenciaAll = new DataTable();
            AsistenciaAll.Columns.Add("Id", typeof(int));
            AsistenciaAll.Columns.Add("Fecha", typeof(DateTime));
            AsistenciaAll.Columns.Add("Tipo", typeof(string));
            AsistenciaAll.Columns.Add("Comentario", typeof(string));
            AsistenciaAll.Columns.Add("IdAsigEstudinate", typeof(int));
            AsistenciaAll.Columns.Add("IdBloqueAsigCurso", typeof(int));

            foreach (var item in ListConcat)
            {
                AsistenciaAll.Rows.Add(new Object[] {
                    null,
                    fecha1,
                    item.Tipo,
                    "",
                    item.IdAsigEstudinate,
                    IdBlkAsCu1
                });
            }

            for (int i = 0; i < AsistenciaAll.Rows.Count; i++)
            {
                asistencia.Id = Convert.ToInt32(ListaIdAsis1[i]); //No debe ser NULL
                asistencia.Fecha = Convert.ToDateTime(AsistenciaAll.Rows[i]["Fecha"]);
                asistencia.Tipo = Convert.ToString(AsistenciaAll.Rows[i]["Tipo"]);
                asistencia.Comentario = Convert.ToString(ListaComent1[i]);
                asistencia.IdAsigEstudinate = Convert.ToInt32(AsistenciaAll.Rows[i]["IdAsigEstudinate"]);
                asistencia.IdBloqueAsigCurso = Convert.ToInt32(AsistenciaAll.Rows[i]["IdBloqueAsigCurso"]);

                db.Asistencia.Update(asistencia);
                db.Save();
            }

            //ViewData["nall"] = NotaAll;
            //ViewData["save"] = nota;

            TempData["error"] = "dodo";
            //return View(nota);

            return RedirectToAction(nameof(TblAsistencia));


        }

        //sin usar
        [HttpGet]
        public IActionResult GetAllAsis(int IdBlkAsCu, int IdCicloEscolar, string Fecha)
        {
            ViewData["IdBlkAsCu"] = IdBlkAsCu;
            ViewData["IdCicloEscolar"] = IdCicloEscolar;


            return Json(new
            {
                data = db.Asistencia.GetListaAsistenciaBloque(IdBlkAsCu, IdCicloEscolar, Fecha)
            }
            );
        }







        [HttpGet]
        public IActionResult CreateAsistencia(int? IdBlkAsCu, int IdCicloEscolar, int IdAsigCurso)
        {
            //ViewBag.IdBlkAsCu = IdBlkAsCu;
            //ViewBag.IdCicloEscolar = IdCicloEscolar;
            //ViewBag.IdAsigCurso = IdAsigCurso;
            ViewData["idBlkAsCu"] = IdBlkAsCu;
            ViewData["IdCicloEscolar"] = IdCicloEscolar;
            ViewData["IdAsigCurso"] = IdAsigCurso;


            return View();
        }

        [HttpGet]
        public IActionResult CreateAsistenciaLstEst(int? IdBlkAsCu, int? est, int IdCicloEscolar, int IdAsigCurso)
        {
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


        [HttpPost]
        public IActionResult SaveAsistencia(string[] ListaAsEs1, string[] ListaTipo1, string[] ListaComent1, int IdBlkAsCu1, string fecha1)
        {
            Asistencia asistencia = new Asistencia();

            var ListConcat = ListaAsEs1.Zip(ListaTipo1, (ides, tpas) => new { IdAsigEstudinate = ides, Tipo = tpas });

            DataTable AsistenciaAll = new DataTable();
            AsistenciaAll.Columns.Add("Id", typeof(int));
            AsistenciaAll.Columns.Add("Fecha", typeof(DateTime));
            AsistenciaAll.Columns.Add("Tipo", typeof(string));
            AsistenciaAll.Columns.Add("Comentario", typeof(string));
            AsistenciaAll.Columns.Add("IdAsigEstudinate", typeof(int));
            AsistenciaAll.Columns.Add("IdBloqueAsigCurso", typeof(int));

            foreach (var item in ListConcat)
            {
                AsistenciaAll.Rows.Add(new Object[] {
                    null,
                    fecha1,
                    item.Tipo,
                    "",
                    item.IdAsigEstudinate,
                    IdBlkAsCu1
                });
            }

            for (int i = 0; i < AsistenciaAll.Rows.Count; i++)
            {
                asistencia.Id = null; //No debe ser NULL
                asistencia.Fecha = Convert.ToDateTime(AsistenciaAll.Rows[i]["Fecha"]);
                asistencia.Tipo = Convert.ToString(AsistenciaAll.Rows[i]["Tipo"]);
                asistencia.Comentario = Convert.ToString(ListaComent1[i]);
                asistencia.IdAsigEstudinate = Convert.ToInt32(AsistenciaAll.Rows[i]["IdAsigEstudinate"]);
                asistencia.IdBloqueAsigCurso = Convert.ToInt32(AsistenciaAll.Rows[i]["IdBloqueAsigCurso"]);

                db.Asistencia.Add(asistencia);
                db.Save();
            }

            //ViewData["nall"] = NotaAll;
            //ViewData["save"] = nota;

            TempData["error"] = "dodo";
            //return View(nota);

            return RedirectToAction(nameof(TblAsistencia));


        }


    }
}
