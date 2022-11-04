using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIEBCE.Models.ViewModels
{
    public class RepCiEsVM
    {
        public AsigEstudiante AsigEstudiante { get; set; }

        public Grado gradoAs { get; set; }

        public Seccion SeccionAs { get; set; }
        /////////////////

        public int CantX { get; set; }

        public int CantY { get; set; }

        public string StrCantX { get; set; }

        public string StrCantY { get; set; }

        public IEnumerable<Grado> Grados { get; set; }

        public IEnumerable<Seccion> Secciones { get; set; }


        //public AsigCurso AsigCurso { get; set; }

        //public IEnumerable<SelectListItem> ListaCatedratico { get; set; }


    }
}
