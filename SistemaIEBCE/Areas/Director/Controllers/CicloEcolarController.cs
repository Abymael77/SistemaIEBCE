using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SistemaIEBCE.AccesoDatos.Data.Repository;
using SistemaIEBCE.Models;
using SistemaIEBCE.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SistemaIEBCE.Areas.Director.Controllers
{
    [Authorize(Roles ="Director")]
    [Area("Director")]
    public class CicloEcolarController : Controller
    {
        private readonly IContenedorTrabajo db;

        //public NotaController(IContenedorTrabajo DbContext)
        //{
        //    db = DbContext;
        //}

        public CicloEcolarController( IContenedorTrabajo _db)
        {
            db = _db;
        }

        public IActionResult Index()
        {
            return View();
        }

        
    }
}