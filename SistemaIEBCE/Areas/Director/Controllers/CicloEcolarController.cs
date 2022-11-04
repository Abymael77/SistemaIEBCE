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
    //[Authorize(Roles ="Director")]
    [Area("Director")]
    public class CicloEcolarController : Controller
    {
        private readonly IContenedorTrabajo db;
        private readonly IConfiguration configuration;


        //public NotaController(IContenedorTrabajo DbContext)
        //{
        //    db = DbContext;
        //}

        public CicloEcolarController(IConfiguration _configuration, IContenedorTrabajo _db)
        {
            configuration = _configuration;
            db = _db;
        }

        [HttpGet]
        public IActionResult Ciclos()
        {
            IEnumerable<CicloEscolar> cies = db.CicloEscolar.GetListaCicloEscolar();
            return View(cies);
        }


        [HttpGet]
        public IActionResult CicloNuevo(int anio)
        {
            var repe = 0;
            IEnumerable<CicloEscolar> ciesc = db.CicloEscolar.GetListaCicloEscolar();
            foreach (var ciclo in ciesc)
            {
                if (ciclo.Anio == anio)
                {
                    repe = 1;
                }
            }

            if (repe == 0)
            {
                IEnumerable<CicloEscolar> ciesAc = db.CicloEscolar.GetAll(filter: c => c.Estado == 1);
                foreach (var item in ciesAc)
                {
                    item.Estado = 0;
                    db.CicloEscolar.Update(item);
                    db.Save();
                }


                IEnumerable<Seccion> sec = db.Seccion.GetAll(filter: s => s.Estado == 1);
                IEnumerable<Grado> gr = db.Grado.GetAll(filter: g => g.Estado == 1);

                foreach (var itemGr in gr)
                {

                    foreach (var itemSec in sec)
                    {
                        CicloEscolar cies = new CicloEscolar();
                        //cies.Anio = DateTime.Now.Year;
                        cies.Anio = anio;
                        cies.IdGrado = itemGr.Id;
                        cies.IdSeccion = itemSec.Id;
                        cies.Estado = 1;

                        db.CicloEscolar.Add(cies);
                        db.Save();
                    }

                }
            }

            return RedirectToAction(nameof(Ciclos));
        }

        [HttpGet]
        public IActionResult CicloCerrar(int anio)
        {
            IEnumerable<CicloEscolar> cies = db.CicloEscolar.GetAll(filter: c => c.Anio == anio);

            foreach (var item in cies)
            {
                item.Estado = 0;
                db.CicloEscolar.Update(item);
                db.Save();
            }

            return RedirectToAction(nameof(Ciclos));
        }

        [HttpGet]
        public IActionResult CicloAbrir(int anio)
        {
            IEnumerable<CicloEscolar> ciesAc = db.CicloEscolar.GetAll(filter: c => c.Estado == 1);
            foreach (var item in ciesAc)
            {
                item.Estado = 0;
                db.CicloEscolar.Update(item);
                db.Save();
            }

            IEnumerable<CicloEscolar> cies = db.CicloEscolar.GetAll(filter: c => c.Anio == anio);

            foreach (var item in cies)
            {
                item.Estado = 1;
                db.CicloEscolar.Update(item);
                db.Save();
            }

            return RedirectToAction(nameof(Ciclos));
        }

        [HttpGet]
        public IActionResult Index(int anio)
        {
            TempData["anio"] = anio;
            return View();
        }

        [HttpGet]
        public IActionResult EstPorGrado(int anio)
        {

            List<RepCiEsVM> repEstuGrado = new List<RepCiEsVM>();

            var conn = configuration.GetValue<string>("ConnectionStrings:conSQL2");

            using ( SqlConnection conexion = new SqlConnection(conn))
            {
                string query = "SP_RetornarEstuPorGrado";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@anio", anio);

                
                conexion.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        repEstuGrado.Add(new RepCiEsVM()
                        {
                            StrCantY = dr["NomGrado"].ToString(),
                            CantX = int.Parse(dr["cantidad"].ToString()),
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
        public IActionResult EstuPorGradoSecc(int anio)
        {

            List<RepCiEsVM> repEstuGrado = new List<RepCiEsVM>();

            var conn = configuration.GetValue<string>("ConnectionStrings:conSQL2");

            using ( SqlConnection conexion = new SqlConnection(conn))
            {
                string query = "SP_RetornarEstuPorGradoSecc";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@anio", anio);

                
                conexion.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        repEstuGrado.Add(new RepCiEsVM()
                        {
                            StrCantY = dr["NomGrado"].ToString() + "-" + dr["NomSeccion"].ToString(),
                            CantX = int.Parse(dr["cantidad"].ToString()),
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
        public IActionResult EstuPorEstado(int anio)
        {

            List<RepCiEsVM> repEstuGrado = new List<RepCiEsVM>();

            var conn = configuration.GetValue<string>("ConnectionStrings:conSQL2");

            using ( SqlConnection conexion = new SqlConnection(conn))
            {
                string query = "SP_RetornarEstuPorEstado";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@anio", anio);

                
                conexion.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        repEstuGrado.Add(new RepCiEsVM()
                        {
                            StrCantY = dr["Estado"].ToString(),
                            CantX = int.Parse(dr["cantidad"].ToString()),
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
        public IActionResult CursosPorGrado(int anio)
        {

            List<RepCiEsVM> repCursosPorGrado = new List<RepCiEsVM>();

            var conn = configuration.GetValue<string>("ConnectionStrings:conSQL2");

            using ( SqlConnection conexion = new SqlConnection(conn))
            {
                string query = "SP_RetornarCursosPorGrado";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@anio", anio);

                
                conexion.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        repCursosPorGrado.Add(new RepCiEsVM()
                        {
                            StrCantY = dr["NomGrado"].ToString(),
                            CantX = int.Parse(dr["cantidad"].ToString()),
                        });
                    }
                }

            }

            return Json(new
            {
                data = repCursosPorGrado
            });

        }


    }
}