using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;

namespace SistemaIEBCE.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class ResetPasswordModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;

        public ResetPasswordModel(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "El Correo es obligatorio")]
            [EmailAddress]
            [Display(Name = "Correo")]
            public string Email { get; set; }

            [Required(ErrorMessage = "La Contaseña Actual es obligatorio")]
            [StringLength(100, ErrorMessage = "La {0} debe ser al menos de {2} y maximo {1} de caracteres de longitud.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Contaseña Actual")]
            public string PasswordActual { get; set; }

            [Required(ErrorMessage = "La Nueva Contaseña es obligatorio")]
            [StringLength(100, ErrorMessage = "La {0} debe ser al menos de {2} y maximo {1} de caracteres de longitud.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Nueva Contaseña")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirmar Nueva Contraseña")]
            [Compare("Password", ErrorMessage = "La contaseña no coincide con la conformación de contraseña")]
            public string ConfirmPassword { get; set; }

            public string Code { get; set; }
        }

        public IActionResult OnGet(string code = null)
        {
            //if (code == null)
            //{
            //    return BadRequest("A code must be supplied for password reset.");
            //}
            //else
            //{
            //Input = new InputModel
            //{
            //    Code = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(code))
            //};
            return Page();
            //}
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var user = await _userManager.FindByEmailAsync(Input.Email);
            if (user == null)
            {
                // Don't reveal that the user does not exist
                return RedirectToPage("./ResetPasswordConfirmation");
            }

            var result = await _userManager.ChangePasswordAsync(user, Input.PasswordActual, Input.Password);
            if (result.Succeeded)
            {
                return RedirectToPage("./ResetPasswordConfirmation");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
            return Page();
        }
    }
}
