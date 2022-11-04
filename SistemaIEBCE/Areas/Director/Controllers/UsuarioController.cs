using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
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
        private readonly UserManager<IdentityUser> _userManager;


        public UsuarioController(IContenedorTrabajo _db, UserManager<IdentityUser> userManager)
        {
            db = _db;
            _userManager = userManager;
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


        public async Task<IActionResult> Delete(string idUser)
        {
            var recordDB = db.Usuario.GetFirstOrDefault(filter: u => u.Id == idUser);
            var user = await _userManager.FindByEmailAsync(recordDB.Email);

            if (recordDB == null || user == null)
            {   
                return Json(new { success = false, message = "Error borrando Usuario" });
            }
            /*
             * Hay que actualizar la tabla de  los usuarios desíusd de una eliminacion 
             * aun no se pude actualuzar
             * ya se eliminan solo falta eso
             */

            var result = await _userManager.DeleteAsync(user);

            if (result.Succeeded)
            {
                //return RedirectToAction(nameof(Index));
                return Json(new { success = true, message = "Usuario borrado correctamente+" });
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
            return Json(new { success = true, message = "Usuario borrado correctamente ----" });
        }
        #endregion
    }
}
