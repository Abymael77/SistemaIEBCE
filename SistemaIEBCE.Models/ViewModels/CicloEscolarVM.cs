using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIEBCE.Models.ViewModels
{
    public class CicloEscolarVM
    {
        public CicloEscolar CicloEscolar { get; set; }

        public IEnumerable<SelectListItem> ListaGrado { get; set; }

        public IEnumerable<SelectListItem> ListaSeccion { get; set; }

    }
}
