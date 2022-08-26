using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SistemaIEBCE.AccesoDatos.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SistemaIEBCE.Areas.Director.Controllers
{
    [Authorize(Roles = "Director")]
    [Area("Director")]
    public class UsuarioController : Controller
    {
        private readonly IContenedorTrabajo db;

        public UsuarioController(IContenedorTrabajo _db)
        {
            db = _db;
        }

        public IActionResult Index()
        {
            var claimsIdentity = (ClaimsIdentity)this.User.Identity;
            var usuarioActual = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            return View(db.Usuario.GetAll(u => u.Id != usuarioActual.Value));
            //u => u.Id != usuarioActual.Value
        }

        public IActionResult Bloquear(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            db.Usuario.BloquearUsuario(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Desbloquear(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            db.Usuario.DesbloquearUsuario(id);
            return RedirectToAction(nameof(Index));
        }

        #region LLAMADAS A LA API
        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new { data = db.Usuario.GetAll() });
        }
        #endregion
    }
}
