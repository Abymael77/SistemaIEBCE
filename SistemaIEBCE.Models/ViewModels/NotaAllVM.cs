using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIEBCE.Models.ViewModels
{
    public class NotaAllVM
    {
        public Nota Nota { get; set; }

        public AsigEstudiante AsigEstudiante { get; set; }

        public Estudiante Estudiante { get; set; }

        //public IEnumerable<Nota> ListaNota { get; set; }

        //public IEnumerable<BloqueAsigCurso> ListaBloque { get; set; }

        //public IEnumerable<AsigEstudiante> ListaEstudiante { get; set; }

        //public IEnumerable<SelectListItem> ListaCurso { get; set; }

        //public IEnumerable<SelectListItem> ListaCicloEscolar { get; set; }

    }
}
