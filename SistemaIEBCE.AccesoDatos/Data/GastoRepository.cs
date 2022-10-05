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
    public class GastoRepository : Repository<Gasto>, IGastoRepository
    {
        private readonly ApplicationDbContext _db;

        public GastoRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
                
        public void Update(Gasto gasto)
        {
            var objDesdeDB = _db.Gasto.FirstOrDefault(s => s.Id == gasto.Id);
            objDesdeDB.NomGasto = gasto.NomGasto;
            objDesdeDB.DescGasto = gasto.DescGasto;
            objDesdeDB.Estado = gasto.Estado;

            _db.SaveChanges();
        }
    }
}
