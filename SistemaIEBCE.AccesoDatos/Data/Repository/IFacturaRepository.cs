using Microsoft.AspNetCore.Mvc.Rendering;
using SistemaIEBCE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIEBCE.AccesoDatos.Data.Repository
{
    public interface IFacturaRepository : IRepository<Factura>
    {
        Factura GetFacturaUltimo();
        void Update(Factura factura);
    }
}
