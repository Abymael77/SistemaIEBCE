using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaIEBCE.Areas.Tesorero.Controllers
{
    [Authorize(Roles = "Tesorero")]
    [Area("Tesorero")]
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
