using Microsoft.AspNetCore.Mvc.Rendering;
using SistemaIEBCE.AccesoDatos.Data.Repository;
using SistemaIEBCE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIEBCE.AccesoDatos.Data
{
    public class ProductoRepository : Repository<Producto>, IProductoRepository
    {
        private readonly ApplicationDbContext _db;

        public ProductoRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetListaProducto()
        {
            List<SelectListItem> list = null;
            int est = 1;

            // consulta Validada por estado 
            var query = (from ca in _db.Producto
                         where ca.Estado == est
                         select new SelectListItem { 
                             Text = ca.NomProducto, 
                             Value = ca.Id.ToString()
                         }).Distinct();
            list = query.ToList();

            return list;
        }

        public void Update(Producto producto)
        {
            var objDesdeDB = _db.Producto.FirstOrDefault(s => s.Id == producto.Id);
            objDesdeDB.NomProducto = producto.NomProducto;
            objDesdeDB.Codigo = producto.Codigo;
            objDesdeDB.Descripcion = producto.Descripcion;
            objDesdeDB.Estado = producto.Estado;

            _db.SaveChanges();
        }
    }
}
