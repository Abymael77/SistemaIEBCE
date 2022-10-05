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
    public class CajaRepository : Repository<Caja>, ICajaRepository
    {
        private readonly ApplicationDbContext _db;

        public CajaRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<Caja> CajaActiva(int est)
        {
            List<Caja> list = null;

            // consulta Validada por estado 
            var query = (from ca in _db.Caja
                         where ca.Estado == est
                         select new Caja { 
                             Id = ca.Id,
                             Inicio = ca.Inicio,
                             Fin = ca.Fin,
                             MontoInicial = ca.MontoInicial,
                             Estado = ca.Estado
                         }).Distinct();
            list = query.ToList();

            return list;
        }

        public void Update(Caja caja)
        {
            var objDesdeDB = _db.Caja.FirstOrDefault(s => s.Id == caja.Id);
            objDesdeDB.Inicio = caja.Inicio;
            objDesdeDB.Fin = caja.Fin;
            objDesdeDB.MontoInicial = caja.MontoInicial;
            objDesdeDB.Estado = caja.Estado;

            _db.SaveChanges();
        }
    }
}
