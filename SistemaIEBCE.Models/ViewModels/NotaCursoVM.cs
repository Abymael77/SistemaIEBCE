using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIEBCE.Models.ViewModels
{
    public class NotaCursoVM
    {
        public AsigCurso AsigCurso { get; set; }

        public IEnumerable<SelectListItem> ListaCatedratico { get; set; }

        public IEnumerable<SelectListItem> ListaCurso { get; set; }

        public IEnumerable<SelectListItem> ListaCicloEscolar { get; set; }

    }
}
