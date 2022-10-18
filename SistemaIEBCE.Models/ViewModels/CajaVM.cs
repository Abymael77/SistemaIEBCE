using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIEBCE.Models.ViewModels
{
    public class CajaVM
    {
        public Caja Caja { get; set; }

        public Factura Factura { get; set; }

        public DetalleFactura DetalleFactura { get; set; }

        public IEnumerable<DetalleFacturaVM> DetalleFacturaVM { get; set; } //ok

        public IEnumerable<Cuota> Cuotas { get; set; }

        public DetalleGasto DetalleGasto { get; set; }

        public IEnumerable<DetalleGasto> DetalleGastoLst { get; set; }

        public Gasto Gasto { get; set; }

        public IEnumerable<Gasto> Gastos { get; set; }
    }
}
