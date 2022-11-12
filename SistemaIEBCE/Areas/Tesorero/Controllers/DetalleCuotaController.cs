using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SistemaIEBCE.AccesoDatos.Data.Repository;
using SistemaIEBCE.Models;
using SistemaIEBCE.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Http;
using SistemaIEBCE.Extensions;

namespace SistemaIEBCE.Areas.Director.Controllers
{
    [Authorize(Roles = "Tesorero,Director")]
    [Area("Tesorero")]
    public class DetalleCuotaController : Controller
    {
        private readonly IContenedorTrabajo db;

        public DetalleCuotaController(IContenedorTrabajo DbContext)
        {
            db = DbContext;
        }

        [HttpGet]
        public IActionResult DetalleCuotaCaja(int idCaja, int idCuota)
        {
            TempData["idCaja"] = idCaja;
            TempData["idCuota"] = idCuota;

            IEnumerable<Cuota> cuota = db.Cuota.GetAll(filter: c => c.Id == idCuota);
            IEnumerable<DetalleFacturaVM> defavm = db.DetalleFactura.GetListIngresoTipoVMVer(idCaja, idCuota);


            CajaVM cajaVM = new CajaVM()
            {
                //DetalleCuota = new Models.DetalleCuota(),
                Cuotas = cuota,
                DetalleFacturaVM = defavm

            };

            return View(cajaVM);
        }



        [HttpGet]
        public IActionResult DetFaturaCuotaCaja(int idFactura)
        {
            IEnumerable<DetaFacVM> defac = db.DetalleFactura.GetDetFacEstud(idFactura);

            //AsigEstudiante asigEstudiante = db.AsigEstudiante.GetFirstOrDefault(filter: ases => ases.Id == IdAsEs, includePropieties: "Estudiante");

            //ViewData["NomEstudiante"] = asigEstudiante.Estudiante.NomEstudiante + asigEstudiante.Estudiante.ApellEstudiante;

            return View(defac);
        }


    }
}
