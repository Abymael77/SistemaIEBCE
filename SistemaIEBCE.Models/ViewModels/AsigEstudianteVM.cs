using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIEBCE.Models.ViewModels
{
    public class AsigEstudianteVM
    {
        public AsigEstudiante AsigEstudiante { get; set; }

        public IEnumerable<SelectListItem> ListaEstudiante { get; set; }

        public IEnumerable<SelectListItem> ListaCicloEscolar { get; set; }

        public IEnumerable<AsigEstudiante> ListaEstudianteNota { get; set; }

    }
}
