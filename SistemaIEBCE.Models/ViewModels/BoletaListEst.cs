using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIEBCE.Models.ViewModels
{
    public class BoletaListEst
    {
        public AsigEstudiante AsigEstudiante { get; set; }
        
        public IEnumerable<AsigEstudiante> AsigEstudianteLs { get; set; }

        public IEnumerable<Estudiante> ListaEstudiante { get; set; }

        public CicloEscolar ListaCicloEscolar { get; set; }

        public IEnumerable<Grado> ListaGrado { get; set; }

        public IEnumerable<Seccion> ListaSeccion { get; set; }

    }
}
