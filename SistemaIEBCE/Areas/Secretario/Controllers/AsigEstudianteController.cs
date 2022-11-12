using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
    [Authorize(Roles = "Secretario,Director")]
    [Area("Secretario")]
    public class AsigEstudianteController : Controller
    {
        private readonly IContenedorTrabajo db;
        private readonly IConfiguration configuration;

        public AsigEstudianteController(IConfiguration _configuration, IContenedorTrabajo DbContext)
        {
            configuration = _configuration;
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
            AsigEstudianteVM asigEstVm = new AsigEstudianteVM()
            {
                AsigEstudiante = new Models.AsigEstudiante(),
                ListaEstudiante = db.AsigEstudiante.GetListaAsigEstudiante(),
                ListaCicloEscolar = db.AsigEstudiante.GetListaAsigCicloEscolar()
            };
            return View(asigEstVm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(AsigEstudianteVM AsigEstudianteVM)
        {
            var exist = 0;
            var grado = "";
            try
            {
                var anio = 0;
                //IEnumerable<CicloEscolar> cies = db.CicloEscolar.GetListaCicloEscolar();
                IEnumerable<CicloEscolar> ciesEst = db.CicloEscolar.GetListaCicloEscolarEst(1);

                foreach (var item in ciesEst)
                {
                    anio = item.Anio;
                }

                IEnumerable<AsigEstudianteVM> ases = db.AsigEstudiante.GetListaAsigEstCuclo(anio);
                foreach (var item in ases)
                {
                    if (item.idEstu == AsigEstudianteVM.AsigEstudiante.IdEstudiante)
                    {
                        exist = 1;
                        grado = item.cicloEscolar;
                    }
                }
                if (ModelState.IsValid & exist == 0)
                {
                    //insertar nueva asignacion
                    db.AsigEstudiante.Add(AsigEstudianteVM.AsigEstudiante);
                    db.Save();

                    var conn = configuration.GetValue<string>("ConnectionStrings:conSQL2");

                    var queryAsEs = "SELECT TOP 1 * FROM AsigEstudiante AS ases ORDER BY ases.Id DESC";
                    SqlDataAdapter RQueryAsEs = new SqlDataAdapter(queryAsEs, conn);

                    DataTable dtAsEs = new DataTable();
                    RQueryAsEs.Fill(dtAsEs);

                    var queryBlAsCu = "SELECT blascu.Id FROM BloqueAsigCurso AS blascu INNER JOIN AsigCurso AS ascu ON ascu.Id = blascu.IdAsigCurso INNER JOIN Bloque AS bl ON bl.Id = blascu.IdBloque WHERE ascu.IdCicloEscolar = " + dtAsEs.Rows[0]["IdCicloEscolar"].ToString();
                    SqlDataAdapter RQueryBlAsCu = new SqlDataAdapter(queryBlAsCu, conn);

                    DataTable dtBlAsCu = new DataTable();
                    RQueryBlAsCu.Fill(dtBlAsCu);

                    Nota nota = new Nota();

                    foreach (DataRow item in dtBlAsCu.Rows)
                    {
                        nota.Id = null;
                        nota.IdAsigEstudinate = (int)dtAsEs.Rows[0]["Id"];
                        nota.IdBloqueAsigCurso = (int)item["Id"];
                        nota.Punteo = 0;

                        db.Nota.Add(nota);
                        db.Save();
                    }


                    TempData["error"] = "dodo";
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    if (exist == 1)
                    {
                        TempData["error"] = "El Estudiante ya Esta Asignado en \n" + grado;
                    }
                    else
                    {
                        TempData["error"] = "Error en validación de modelo.";
                    }
                    AsigEstudianteVM.ListaEstudiante = db.AsigEstudiante.GetListaAsigEstudiante();
                    AsigEstudianteVM.ListaCicloEscolar = db.AsigEstudiante.GetListaAsigCicloEscolar();
                    return View(AsigEstudianteVM);
                }
            }
            catch (Exception)
            {
                TempData["error"] = "Error de sistema.";
                AsigEstudianteVM.ListaEstudiante = db.AsigEstudiante.GetListaAsigEstudiante();
                AsigEstudianteVM.ListaCicloEscolar = db.AsigEstudiante.GetListaAsigCicloEscolar();
                return View(AsigEstudianteVM);
            }
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            int iiid = (int)id;
            try
            {
                AsigEstudiante ases = db.AsigEstudiante.GetFirstOrDefault(filter: e => e.Id == id);
                CicloEscolar cies = db.CicloEscolar.GetFirstOrDefault(filter: c => c.Id == ases.IdCicloEscolar, includePropieties: "Grado,Seccion");
                AsigEstudianteVM asigEstVm = new AsigEstudianteVM()
                {
                    AsigEstudiante = new Models.AsigEstudiante(),
                    ListaEstudiante = db.AsigEstudiante.GetListaAsigEstudiante(),
                    ListaCicloEscolar = db.AsigEstudiante.GetListaAsigCicloEscolar(),
                    cicloEscolar = cies.Grado.NomGrado + " - " + cies.Seccion.NomSeccion + " - " + cies.Anio
                };

                if (id != null)
                {
                    asigEstVm.AsigEstudiante = db.AsigEstudiante.GetFirstOrDefault(filter: a => a.Id == iiid, includePropieties: "Estudiante");
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
        public IActionResult Edit(AsigEstudianteVM AsigEstudianteVMres)
        {
            try
            {
                
                if (ModelState.IsValid)
                {
                    db.AsigEstudiante.Update(AsigEstudianteVMres.AsigEstudiante);
                    db.Save();
                    TempData["error"] = "dodo";
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    TempData["error"] = "Error en validación de modelo.";
                    AsigEstudianteVMres.ListaEstudiante = db.AsigEstudiante.GetListaAsigEstudiante();
                    AsigEstudianteVMres.ListaCicloEscolar = db.AsigEstudiante.GetListaAsigCicloEscolar();
                    return View(AsigEstudianteVMres);
                }
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error de sistema.";
                AsigEstudianteVMres.ListaEstudiante = db.AsigEstudiante.GetListaAsigEstudiante();
                AsigEstudianteVMres.ListaCicloEscolar = db.AsigEstudiante.GetListaAsigCicloEscolar();
                return View(AsigEstudianteVMres);
            }
        }


        #region LLAMADAS A LA API
        [HttpGet]
        public IActionResult GetAll()
        {
            //string cadena = "Server=localhost;Database=SistemaIEBCE;User ID=abimael;Password=admin123;Trusted_Connection=False;";
            //SqlConnection con = new SqlConnection(cadena);
            //SqlDataAdapter consulta = new SqlDataAdapter("SELECT * FROM AsigEstudiante",con);
            //return Json(consulta);

            return Json(new
            {
                data = db.AsigEstudiante.GetAll(includePropieties: "Estudiante,CicloEscolar"),
                //data1 = db.Grado.GetAll(includePropieties: "Grado"),
                //data2 = db.Seccion.GetAll(includePropieties: "Seccion")
            }
            );
        }
        [HttpGet]
        public IActionResult GetAllCiEs()
        {
            //var anio = DateTime.Now.Year;
            var anio = 0;
            //IEnumerable<CicloEscolar> cies = db.CicloEscolar.GetListaCicloEscolar();
            IEnumerable<CicloEscolar> ciesEst = db.CicloEscolar.GetListaCicloEscolarEst(1);

            foreach (var item in ciesEst)
            {
                anio = item.Anio;
            }

            return Json(new
            {
                data = db.AsigEstudiante.GetListaAsigEstCuclo(anio)
            }
            );
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                var recordDB = db.AsigEstudiante.Get(id);
                if (recordDB == null)
                {
                    return Json(new { success = false, message = "Error borrando Ciclo Escolar" });
                }

                db.AsigEstudiante.Remove(recordDB);
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
