using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SistemaIEBCE.AccesoDatos.Data.Repository;
using SistemaIEBCE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Http;
using SistemaIEBCE.Extensions;


namespace SistemaIEBCE.Areas.Tesorero.Controllers
{
    [Authorize(Roles = "Tesorero")]
    [Area("Tesorero")]
    public class MenuController : Controller
    {
        private readonly IContenedorTrabajo db;

        public MenuController(IContenedorTrabajo DbContext)
        {
            db = DbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var ca = db.Caja.CajaActiva(1);
            //Caja cajaEst = new Caja();


            Caja cajaEst;
            if (HttpContext.Session.GetString("SESSION") == null)
            {
                //No existe nada en la session, creamos la coleccion
                cajaEst = new Caja();
            }
            else
            {
                cajaEst = HttpContext.Session.GetObject<Caja>("SESSION");
            }

            foreach (Caja c in ca)
            {
                cajaEst.Id = c.Id;
                cajaEst.Inicio = c.Inicio;
                cajaEst.Fin = c.Fin;
                cajaEst.MontoInicial = c.MontoInicial;
                cajaEst.Estado = c.Estado;
            }

            HttpContext.Session.SetObject("cajaEst", cajaEst);
            
            return View();
        }
    }
}
