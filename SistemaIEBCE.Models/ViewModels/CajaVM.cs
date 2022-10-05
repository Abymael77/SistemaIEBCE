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

        public DetalleGasto DetalleGasto { get; set; }
    }
}
