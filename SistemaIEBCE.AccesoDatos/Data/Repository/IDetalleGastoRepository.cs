using Microsoft.AspNetCore.Mvc.Rendering;
using SistemaIEBCE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIEBCE.AccesoDatos.Data.Repository
{
    public interface IDetalleGastoRepository : IRepository<DetalleGasto>
    {

        void Update(DetalleGasto detalleGasto);
    }
}
