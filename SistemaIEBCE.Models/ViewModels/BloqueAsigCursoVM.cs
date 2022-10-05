using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIEBCE.Models.ViewModels
{
    public class BloqueAsigCursoVM
    {
        public BloqueAsigCurso BloqueAsigCurso { get; set; }

        public IEnumerable<SelectListItem> ListaBloqueCrear { get; set; }

        public IEnumerable<BloqueAsigCurso> ListaBloque { get; set; }


    }
}
