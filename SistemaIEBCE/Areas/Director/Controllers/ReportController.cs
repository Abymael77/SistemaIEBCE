using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SistemaIEBCE.AccesoDatos.Data.Repository;
using SistemaIEBCE.Models;
using SistemaIEBCE.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaIEBCE.Areas.Director.Controllers
{
    //[Authorize(Roles = "Director")]
    [Area("Director")]
    public class ReportController : Controller
    {
        private readonly IContenedorTrabajo db;
        private readonly IConfiguration configuration;

        public ReportController(IConfiguration _configuration, IContenedorTrabajo _db)
        {
            configuration = _configuration;
            db = _db;
        }

        public IActionResult RankingEstud(int anio)
        {
            ViewData["return"] = anio;
            //int anio = 0;
            if (anio == 1)
            {
                IEnumerable<CicloEscolar> ciesAc = db.CicloEscolar.GetAll(filter: c => c.Estado == 1);
                foreach (var item in ciesAc)
                {
                    anio = item.Anio;
                }
            }

            IEnumerable<NotaRep> nt = db.Nota.GetEstDestacados(anio,15);
            IEnumerable<NotaRep> ntTop3 = db.Nota.GetEstDestacados(anio,3);

            //return Json(new
            //{
            //    data = db.Nota.GetEstDestacados(2021)
            //});

            ViewData["anio"] = anio;
            ViewData["notas"] = nt;
            ViewData["ntTop3"] = ntTop3;

            return View();
        }
    }
}
