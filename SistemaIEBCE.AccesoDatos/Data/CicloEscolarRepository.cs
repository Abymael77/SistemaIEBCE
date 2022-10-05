using Microsoft.AspNetCore.Mvc.Rendering;
using SistemaIEBCE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIEBCE.AccesoDatos.Data.Repository
{
    public class CicloEscolarRepository : Repository<CicloEscolar>, ICicloEscolarRepository
    {
        private readonly ApplicationDbContext _db;

        public CicloEscolarRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetListaCicloEscolar()
        {
            List<SelectListItem> list = null;
            int est = 1;

            // consulta Validada por estado 
            var query = (from ca in _db.CicloEscolar
                         where ca.Estado == est
                         select new SelectListItem { Text = ca.Anio.ToString(), Value = ca.Id.ToString() }).Distinct();
            list = query.ToList();

            return list;
        }

        public void Update(CicloEscolar cicloEscolar)
        {
            var objDesdeDB = _db.CicloEscolar.FirstOrDefault(s => s.Id == cicloEscolar.Id);
            objDesdeDB.Anio = cicloEscolar.Anio;
            objDesdeDB.IdGrado = cicloEscolar.IdGrado;
            objDesdeDB.IdSeccion = cicloEscolar.IdSeccion;
            objDesdeDB.Estado = cicloEscolar.Estado;

            _db.SaveChanges();
        }

    }
}
