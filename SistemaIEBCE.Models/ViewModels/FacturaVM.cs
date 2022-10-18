using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIEBCE.Models.ViewModels
{
    public class FacturaVM
    {
        public Factura Factura { get; set; } //

        public Caja Caja { get; set; } //

        public AsigEstudiante AsigEstudiante { get; set; }

        public AsigEstudianteVM AsigEstudianteVM { get; set; }

        public DetalleFactura DetalleFactura { get; set; }

        public IEnumerable<Estudiante> Estudiantes { get; set; }

        public IEnumerable<AsigEstudiante> AsigEstudiantes { get; set; }

        public IEnumerable<Cuota> Cuotas { get; set; }
    }
}
