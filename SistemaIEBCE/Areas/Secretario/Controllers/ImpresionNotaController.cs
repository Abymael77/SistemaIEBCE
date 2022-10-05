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
using Newtonsoft.Json;

namespace SistemaIEBCE.Areas.Secretario.Controllers
{
    //[Authorize(Roles = "Secretario")]
    [Area("Secretario")]
    public class ImpresionNotaController : Controller
    {
        private readonly IContenedorTrabajo db;
        private readonly IConfiguration configuration;

        //public ImpresionNotaController(IContenedorTrabajo DbContext)
        //{
        //    db = DbContext;
        //}
        
        public ImpresionNotaController(IConfiguration _configuration, IContenedorTrabajo _db)
        {
            configuration = _configuration;
            db = _db;
        }

        public IActionResult Index()
        {
            return View();
        }



        [HttpGet]
        public IActionResult CicloEscolar(int est)
        {
            return Json(new
            {
                data = db.AsigCurso.GetListaAsigCursoEst(est)
            }
            );
        }

        [HttpGet]
        public IActionResult ListBloque(int idCicEs)
        {
            ViewData["idCicEs"] = idCicEs;

            return View();
        }

        [HttpGet]
        public IActionResult Bloque(int idCicEs)
        {
            TempData["idCicEs"] = idCicEs;

            var conn = configuration.GetValue<string>("ConnectionStrings:conSQL2");
            SqlDataAdapter da = new SqlDataAdapter("SELECT bl.Id, bl.NomBloque, ascu.IdCicloEscolar FROM BloqueAsigCurso AS blascu INNER JOIN Bloque AS bl  On bl.Id = blascu.IdBloque INNER JOIN AsigCurso AS ascu ON ascu.Id = blascu.IdAsigCurso WHERE ascu.IdCicloEscolar = " + idCicEs + " GROUP BY bl.Id, bl.NomBloque, ascu.IdCicloEscolar", conn);

            //cambioooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo
            DataTable dt = new DataTable();

            da.Fill(dt);

            BlGroupVM bl = new BlGroupVM();

            List<BlGroupVM> blgr = new List<BlGroupVM>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                bl.Id = Convert.ToInt32(dt.Rows[i]["Id"]);
                bl.NomBloque = Convert.ToString(dt.Rows[i]["NomBloque"]);
                bl.IdCicloEscolar = Convert.ToInt32(dt.Rows[i]["IdCicloEscolar"]);

                blgr.Add(new BlGroupVM() { Id = bl.Id, NomBloque = bl.NomBloque, IdCicloEscolar = bl.IdCicloEscolar } );

            }


            return Json(new
            {
                data = blgr
            }
            );
        }


        [HttpGet]
        public IActionResult ListEstudiante(int IdBloque, int IdCicloEsc)
        {
            TempData["IdBloque"] = IdBloque;
            ViewData["IdBloque"] = IdBloque;
            ViewData["IdCicloEsc"] = IdCicloEsc;

            return View();
        }

        [HttpGet]
        public IActionResult GetListEstudiante(int IdBloque, int IdCicloEsc)
        {
            ViewData["IdBloque"] = IdBloque;
            return Json(new
            {
                data = db.AsigEstudiante.GetListaAsigEstCiclo(IdCicloEsc)
            }
            );
        }

        [HttpGet]
        public IActionResult ListNota(int? IdBlkAsCu, int? est)
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
                data = db.AsigEstudiante.GetListaNota(idCicloEsc, est),
            }
            );
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
        {
            return Json(new
            {
                data = db.BloqueAsigCurso.GetListaBloqueAsCu(id)
            }
            );
        }
        #endregion

    }
}
