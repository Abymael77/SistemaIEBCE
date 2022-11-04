using Microsoft.AspNetCore.Mvc.Rendering;
using SistemaIEBCE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIEBCE.AccesoDatos.Data.Repository
{
    public interface IProductoRepository : IRepository<Producto>
    {
        IEnumerable<SelectListItem> GetListaProducto();


        void Update(Producto bloque);
    }
}
