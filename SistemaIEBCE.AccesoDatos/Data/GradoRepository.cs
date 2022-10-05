using Microsoft.AspNetCore.Mvc.Rendering;
using SistemaIEBCE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIEBCE.AccesoDatos.Data.Repository
{
    public class GradoRepository : Repository<Grado>, IGradoRepository
    {
        private readonly ApplicationDbContext _db;

        public GradoRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetListaGrado()
        {
            List<SelectListItem> list = null;
            int est = 1;

            // consulta Validada por estado 
            var query = (from ca in _db.Grado
                         where ca.Estado == est
                         select new SelectListItem { Text = ca.NomGrado, Value = ca.Id.ToString() }).Distinct();
            list = query.ToList();

            return list;
        }

        public void Update(Grado grado)
        {
            var objDesdeDB = _db.Grado.FirstOrDefault(s => s.Id == grado.Id);
            objDesdeDB.NomGrado = grado.NomGrado;
            objDesdeDB.Estado = grado.Estado;

            _db.SaveChanges();
        }
    }
}
