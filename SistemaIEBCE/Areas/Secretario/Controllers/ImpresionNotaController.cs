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
            if (IdBloque == 0 || IdCicloEsc == 0)
            {
                return RedirectToAction("Error?StatusCode=404", "Menu", "Invitado");
            }
            TempData["IdBloque"] = IdBloque;
            ViewData["IdBloque"] = IdBloque;
            ViewData["IdCicloEsc"] = IdCicloEsc;

            return View();
        }

        [HttpGet]
        public IActionResult GetListEstudiante(int IdBloque, int IdCicloEsc)
        {
            if (IdBloque == 0 || IdCicloEsc == 0)
            {
                return RedirectToAction("Error?StatusCode=404", "Menu", "Invitado");
            }
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


        public IActionResult Boleta(int idAsigEstudinate, int IdBloque)
        {
            if (idAsigEstudinate == 0 || IdBloque == 0)
            {
                return RedirectToAction("Error?StatusCode=404", "Menu", "Invitado");
            }
            ViewData["idBloque"] = IdBloque;
            ViewData["idAsigEstudinate"] = idAsigEstudinate;
            TempData["idBloque"] = IdBloque;
            TempData["idAsigEstudinate"] = idAsigEstudinate;
            return View();
        }

        [HttpGet]
        public IActionResult ListNotaCurso(int idAsigEstudinate, int idBloque)
        {
            if (idAsigEstudinate == 0 || idBloque == 0)
            {
                return RedirectToAction("Error?StatusCode=404", "Menu", "Invitado");
            }
            ViewData["idAsigEstudinate"] = idAsigEstudinate;

            //idAsigEstudinate = (int)TempData["idAsigEstudinate"];
            // idBloque = (int)TempData["idBloque"];


            return Json(new
            {
                data = db.AsigEstudiante.GetListaNotaBlk(idAsigEstudinate, idBloque)
            }
            );
        }

        //boleta con promedio 
        public IActionResult BoletaPromedio(int idAsigEstudinate)
        {
            if (idAsigEstudinate == 0)
            {
                return RedirectToAction("Error?StatusCode=404", "Menu", "Invitado");
            }
            ViewData["idAsigEstudinate"] = idAsigEstudinate;
            TempData["idAsigEstudinate"] = idAsigEstudinate;

            NotaPromedioVM notas = new NotaPromedioVM()
            {
                ListaNota = db.AsigEstudiante.GetListaNotaPromedio(idAsigEstudinate),
                ListaBloque = db.AsigEstudiante.GetListaBloque(idAsigEstudinate),
                ListaCurso = db.AsigEstudiante.GetListaCurso(idAsigEstudinate)
            };

            DataTable dt = new DataTable();

            dt.Columns.Add("No.", typeof(int));
            dt.Columns.Add("Curso", typeof(string));

            //strinf de nombre s de colimnas
            var colsname = "";
            foreach (var itemBlk in notas.ListaBloque)
            {
                dt.Columns.Add(itemBlk.Text, typeof(int));
                //colsname += itemBlk.Text + "+";
            }


            foreach (var itemCur in notas.ListaCurso)
            {
                dt.Rows.Add(new object[] {
                    0,
                    itemCur.Text,

                });
            }

            foreach (var itemCur in notas.ListaCurso)
            {
                //dt.Rows.Add(new object[] {
                //    itemCur.Value,
                //    itemCur.Text,

                //});

                foreach (var itemBlk in notas.ListaBloque)
                {
                    foreach (var itemNt in notas.ListaNota)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            //CursoId = dt.Columns[itemCur.Value].ColumnName;
                            //CursoId = dt.Rows[i]["Curso"].ToString();
                            //if (Convert.ToInt32(itemCur.Value) == itemNt.Curso.Id && Convert.ToInt32(itemBlk.Value) == itemNt.Bloque.Id)
                            if (dt.Rows[i]["Curso"].ToString() == itemNt.Curso.NomCurso.ToString() && dt.Columns[itemBlk.Text].ColumnName == itemNt.Bloque.NomBloque.ToString())
                            {
                                //CursoId = itemNt.Curso.Id.ToString();
                                //BloqueId = itemNt.Bloque.Id.ToString();
                                dt.Rows[i][itemBlk.Text] = itemNt.Punteo;
                            }
                        }
                         
                    }
                    
                }
            }
            dt.Columns.Add("Promedio", typeof(decimal));


            //dt.Columns["Promedio"].Expression = colsname + "2";
            var res = 0;
            foreach (DataRow dtrow in dt.Rows)
            {
                foreach (DataColumn dtcol in dt.Columns)
                {
                    if (dtcol.ColumnName != "No." && dtcol.ColumnName != "Curso" && dtcol.ColumnName != "Promedio")
                    {
                        if (dtrow[dtcol.ColumnName].ToString() == "" || dtrow[dtcol.ColumnName].ToString() == null)
                        {
                            dtrow[dtcol.ColumnName] = 0;
                        }
                        res = res + Convert.ToInt32(dtrow[dtcol.ColumnName]);
                    }
                }

                res = res + 0;
                dtrow["Promedio"] = res/notas.ListaBloque.Count();
                res = 0;
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["No."] = i+1;
            }
            //de momenmto ya se itera i todo  pero sustitulle todos los valores en cada fila con 
            //el ultimo regisstro de nota 
            //hay que evitar la sobreescritura de las notas anteriores en la tabla

            return View(dt);
        }

        [HttpGet]
        public IActionResult ListNotaCursoPromedio(int idAsigEstudinate)
        {
            if (idAsigEstudinate == 0)
            {
                return RedirectToAction("Error?StatusCode=404", "Menu", "Invitado");
            }
            ViewData["idAsigEstudinate"] = idAsigEstudinate;

            //idAsigEstudinate = (int)TempData["idAsigEstudinate"];
            // idBloque = (int)TempData["idBloque"];


            return Json(new
            {
                notas = db.AsigEstudiante.GetListaNotaPromedio(idAsigEstudinate),
                bloque = db.AsigEstudiante.GetListaBloque(idAsigEstudinate),
                cursos = db.AsigEstudiante.GetListaCurso(idAsigEstudinate)
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
