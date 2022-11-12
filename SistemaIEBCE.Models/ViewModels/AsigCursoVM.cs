using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIEBCE.Models.ViewModels
{
    public class AsigCursoVM
    {
        public AsigCurso AsigCurso { get; set; }

        public CicloEscolar CicloEscolar11 { get; set; }

        public IEnumerable<SelectListItem> ListaCatedratico { get; set; }

        public IEnumerable<SelectListItem> ListaCurso { get; set; }

        public IEnumerable<SelectListItem> ListaCicloEscolar { get; set; }

        public int id { get; set; }
        public string catedratico { get; set; }
        public string curso { get; set; }
        public string cicloEscolar { get; set; }
        public int estado { get; set; }


    }
}
