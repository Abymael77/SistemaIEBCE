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

namespace SistemaIEBCE.Areas.Director.Controllers
{
    [Authorize(Roles = "Tesorero,Director")]
    [Area("Tesorero")]
    public class CuotaController : Controller
    {
        private readonly IContenedorTrabajo db;
        private readonly IConfiguration configuration;

        public CuotaController(IConfiguration _configuration, IContenedorTrabajo DbContext)
        {
            db = DbContext;
            configuration = _configuration;
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Cuota cuota)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    TempData["error"] = "Error en validación de modelo.";
                    return View(cuota);
                }

                db.Cuota.Add(cuota);
                db.Save();
                TempData["error"] = "dodo";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                TempData["error"] = "Error de sistema.";
                return View(cuota);
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            try
            {
                Cuota cuota = new Cuota();
                cuota = db.Cuota.Get(id);

                if (cuota == null)
                {
                    return NotFound();
                }

                return View(cuota);
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error de sistema.";
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Cuota cuota)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    TempData["error"] = "Error en validacion de modelo.";
                    return View(cuota);
                }

                db.Cuota.Update(cuota);
                db.Save();
                TempData["error"] = "dodo";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error de sistema.";
                return View(cuota);
            }
        }



        [HttpGet]
        public IActionResult Estudiantes()
        {
            var anio = 0;
            //IEnumerable<CicloEscolar> cies = db.CicloEscolar.GetListaCicloEscolar();
            IEnumerable<CicloEscolar> ciesEst = db.CicloEscolar.GetListaCicloEscolarEst(1);

            foreach (var item in ciesEst)
            {
                anio = item.Anio;
            }
            IEnumerable<AsigEstudianteVM> ases = db.AsigEstudiante.GetListaAsigEstCuclo(anio);
             
            return View(ases);
        }

        [HttpGet]
        public IActionResult RepPagos(int idAsEs)
        {
            TempData["idAsEs"] = idAsEs;
            AsigEstudiante ases = db.AsigEstudiante.GetFirstOrDefault(filter: e => e.Id == idAsEs, includePropieties: "Estudiante");
            return View(ases);
        }

        [HttpGet]
        public IActionResult CuentaEstudiante(int idAsEs)
        {
            List<RepCiEsVM> repEstuGrado = new List<RepCiEsVM>();

            var conn = configuration.GetValue<string>("ConnectionStrings:conSQL2");

            using (SqlConnection conexion = new SqlConnection(conn))
            {
                string query = "SP_CuentaEstudiante";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idAsEs", idAsEs);


                conexion.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        repEstuGrado.Add(new RepCiEsVM()
                        {
                            StrCantY = dr["NomCuota"].ToString(),
                            CantX = int.Parse(dr["Pagado"].ToString()),
                            CantY = int.Parse(dr["Cantidad"].ToString()),
                        });
                    }
                }

            }

            return Json(new
            {
                data = repEstuGrado
            });
        }

        [HttpGet]
        public IActionResult ListCuotas()
        {
            return Json(new
            {
                data = db.Cuota.GetAll()
            });
        }

        #region LLAMADAS A LA API
        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new { data = db.Cuota.GetAll() });
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                var recordDB = db.Cuota.Get(id);
                if (recordDB == null)
                {
                    return Json(new { success = false, message = "Error borrando Cuota" });
                }

                db.Cuota.Remove(recordDB);
                db.Save();
                TempData["error"] = "dodo";
                return Json(new { success = true, message = "Cuota borrado correctamente" });
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
