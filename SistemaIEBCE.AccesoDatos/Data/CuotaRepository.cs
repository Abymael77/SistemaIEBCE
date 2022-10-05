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
    public class CuotaRepository : Repository<Cuota>, ICuotaRepository
    {
        private readonly ApplicationDbContext _db;

        public CuotaRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
                
        public void Update(Cuota cuota)
        {
            var objDesdeDB = _db.Cuota.FirstOrDefault(s => s.Id == cuota.Id);
            objDesdeDB.NomCuota = cuota.NomCuota;
            objDesdeDB.DescpCuota = cuota.DescpCuota;
            objDesdeDB.Monto = cuota.Monto;
            objDesdeDB.Cantidad = cuota.Cantidad;
            objDesdeDB.Estado = cuota.Estado;

            _db.SaveChanges();
        }
    }
}
