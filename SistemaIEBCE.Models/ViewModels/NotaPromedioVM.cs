using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIEBCE.Models.ViewModels
{
    public class NotaPromedioVM
    {
        public IEnumerable<NotaFull> ListaNota { get; set; }
        
        public IEnumerable<SelectListItem> ListaBloque { get; set; }

        public IEnumerable<SelectListItem> ListaCurso { get; set; }
        
    }
}
