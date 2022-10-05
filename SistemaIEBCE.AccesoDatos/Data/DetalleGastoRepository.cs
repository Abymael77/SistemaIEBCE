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
    public class DetalleGastoRepository : Repository<DetalleGasto>, IDetalleGastoRepository
    {
        private readonly ApplicationDbContext _db;

        public DetalleGastoRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
                
        public void Update(DetalleGasto detalleGasto)
        {
            var objDesdeDB = _db.DetalleGasto.FirstOrDefault(s => s.Id == detalleGasto.Id);
            objDesdeDB.IdGasto = detalleGasto.IdGasto;
            objDesdeDB.IdCaja = detalleGasto.IdCaja;
            objDesdeDB.Monto = detalleGasto.Monto;
            objDesdeDB.Fecha = detalleGasto.Fecha;
            objDesdeDB.NoFactura = detalleGasto.NoFactura;

            _db.SaveChanges();
        }
    }
}
