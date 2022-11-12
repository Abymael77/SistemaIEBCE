using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaIEBCE.AccesoDatos.Data.Repository;
using SistemaIEBCE.Extensions;
using SistemaIEBCE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaIEBCE.Areas.Director.Controllers
{
    [Authorize(Roles = "Director")]
    [Area("Director")]
    public class MenuController : Controller
    {
        private readonly IContenedorTrabajo db;

        public MenuController(IContenedorTrabajo DbContext)
        {
            db = DbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MenuSecretario(int? ciclo)
        {
            CicloEscolar cies;
            if (HttpContext.Session.GetString("SESSION") == null)
            {
                //No existe nada en la session, creamos la coleccion
                cies = new CicloEscolar();
            }
            else
            {
                cies = HttpContext.Session.GetObject<CicloEscolar>("SESSION");
            }


            if (ciclo == 1)
            {
                cies = db.CicloEscolar.GetFirstOrDefault(filter: c => c.Estado == ciclo);
            }
            else
            {
                cies = db.CicloEscolar.GetFirstOrDefault(filter: c => c.Anio == ciclo);
            }
            //Caja cajaEst = new Caja();

            HttpContext.Session.SetObject("CicloEscolar", cies);
            return View();
        }

        public IActionResult MenuTesorero(int? ciclo)
        {
            return View();
        }
    }
}
