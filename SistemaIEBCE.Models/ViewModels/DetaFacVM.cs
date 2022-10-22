using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIEBCE.Models.ViewModels
{
    public class DetaFacVM
    {
        public DetalleFactura DetalleFactura { get; set; }
        
        public IEnumerable<DetalleFactura> DetalleFacturaLst { get; set; }

        public Cuota Cuota { get; set; }

        public Estudiante Estudiante { get; set; }
        
        public Factura Factura { get; set; }

        public Grado Grado { get; set; }
        
        public Seccion Seccion { get; set; }

    }
}
