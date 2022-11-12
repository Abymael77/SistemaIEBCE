using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIEBCE.Models.ViewModels
{
    public class NotaRep
    {
        public int IdAsigEstudinate { get; set; }

        public string NomEstudiante { get; set; }

        public string ApellEstudiante { get; set; }

        public string Sexo { get; set; }

        public string NomGrado { get; set; }

        public string NomSeccion { get; set; }

        public double Nota { get; set; }

    }
}
