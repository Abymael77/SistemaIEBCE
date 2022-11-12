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
    public class CicloEscolarController : Controller
    {
        private readonly IContenedorTrabajo db;
        private readonly IConfiguration configuration;

        public CicloEscolarController(IConfiguration _configuration, IContenedorTrabajo DbContext)
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
            CicloEscolarVM asigEstVm = new CicloEscolarVM()
            {
                CicloEscolar = db.CicloEscolar.GetFirstOrDefault(filter: c => c.Estado == 1),
                ListaGrado = db.Grado.GetListaGrado(),
                ListaSeccion = db.Seccion.GetListaSeccion()
            };
            return View(asigEstVm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CicloEscolarVM CicloEscolarVM)
        {
            var exist = 0;
            try
            {
                IEnumerable<CicloEscolar> cies = db.CicloEscolar.GetAll(filter: c => c.Estado == 1);
                foreach (var item in cies)
                {
                    if (item.IdGrado == CicloEscolarVM.CicloEscolar.IdGrado & item.IdSeccion == CicloEscolarVM.CicloEscolar.IdSeccion)
                    {
                        exist = 1;
                    }
                }
                if (ModelState.IsValid & exist == 0)
                {
                    db.CicloEscolar.Add(CicloEscolarVM.CicloEscolar);
                    db.Save();
                    TempData["error"] = "dodo";
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    if (exist == 1)
                    {
                        TempData["error"] = "Asignación existente";
                    }
                    else
                    {
                        TempData["error"] = "Error en validación de modelo.";
                    }
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
                    asigEstVm.CicloEscolar = db.CicloEscolar.GetFirstOrDefault(filter: c => c.Id == id, includePropieties: "Grado,Seccion");
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
            var anio = 0;
            IEnumerable<CicloEscolar> ciesEst = db.CicloEscolar.GetListaCicloEscolarEst(1);

            foreach (var item in ciesEst)
            {
                anio = item.Anio;
            }
            return Json(new { data = db.CicloEscolar.GetAll(filter: c => c.Anio == anio, includePropieties: "Grado,Seccion") });
        }

        [HttpGet]
        public IActionResult GetAllCiEsNt()
        {
            return Json(new { data = db.CicloEscolar.GetAll(filter: c => c.Estado == 1, includePropieties: "Grado,Seccion") });
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



        #region REPORTES_CICLO_ESCOLAR

        [HttpGet]
        public IActionResult RepCiclo(int id)
        {
            ViewData["IdCiEs"] = id;
            CicloEscolar cies = db.CicloEscolar.GetFirstOrDefault(filter: c => c.Id == id, includePropieties: "Grado,Seccion");
            return View(cies);
        }


        [HttpGet]
        public IActionResult EstPorGenero(int IdCiEs)
        {

            List<RepCiEsVM> repEstuGenero = new List<RepCiEsVM>();

            var conn = configuration.GetValue<string>("ConnectionStrings:conSQL2");

            using (SqlConnection conexion = new SqlConnection(conn))
            {
                string query = "SP_RetornarEstuPorGenero";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdCiEs", IdCiEs);


                conexion.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        repEstuGenero.Add(new RepCiEsVM()
                        {
                            StrCantY = dr["Sexo"].ToString(),
                            CantX = int.Parse(dr["cantidad"].ToString()),
                        });
                    }
                }

            }

            return Json(new
            {
                data = repEstuGenero
            });

        }

        [HttpGet]
        public IActionResult EstuPorGeneroEstado(int IdCiEs, int est)
        {

            List<RepCiEsVM> repEstuGenero = new List<RepCiEsVM>();

            var conn = configuration.GetValue<string>("ConnectionStrings:conSQL2");

            using (SqlConnection conexion = new SqlConnection(conn))
            {
                string query = "SP_RetEstuPorGeneroEstado";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdCiEs", IdCiEs);
                cmd.Parameters.AddWithValue("@est", est);


                conexion.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        repEstuGenero.Add(new RepCiEsVM()
                        {
                            StrCantY = dr["Sexo"].ToString(),
                            CantX = int.Parse(dr["cantidad"].ToString()),
                        });
                    }
                }

            }

            return Json(new
            {
                data = repEstuGenero
            });

        }
        
        [HttpGet]
        public IActionResult EstuPorEstado(int IdCiEs)
        {

            List<RepCiEsVM> repEstuGenero = new List<RepCiEsVM>();

            var conn = configuration.GetValue<string>("ConnectionStrings:conSQL2");

            using (SqlConnection conexion = new SqlConnection(conn))
            {
                string query = "SP_RetCiEsPorEstEstado";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdCiEs", IdCiEs);


                conexion.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        repEstuGenero.Add(new RepCiEsVM()
                        {
                            StrCantY = dr["Estado"].ToString(),
                            CantX = int.Parse(dr["cantidad"].ToString()),
                        });
                    }
                }

            }

            return Json(new
            {
                data = repEstuGenero
            });

        }

        #endregion
    }
}
