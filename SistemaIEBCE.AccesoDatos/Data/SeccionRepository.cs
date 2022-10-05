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
    public class SeccionRepository : Repository<Seccion>, ISeccionRepository
    {
        private readonly ApplicationDbContext _db;

        public SeccionRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetListaSeccion()
        {
            List<SelectListItem> list = null;
            int est = 1;

            // consulta Validada por estado 
            var query = (from ca in _db.Seccion
                         where ca.Estado == est
                         select new SelectListItem { Text = ca.NomSeccion, Value = ca.Id.ToString() }).Distinct();
            list = query.ToList();

            return list;
        }

        public void Update(Seccion seccion)
        {
            var objDesdeDB = _db.Seccion.FirstOrDefault(s => s.Id == seccion.Id);
            objDesdeDB.NomSeccion = seccion.NomSeccion;
            objDesdeDB.Estado = seccion.Estado;

            _db.SaveChanges();
        }
    }
}
