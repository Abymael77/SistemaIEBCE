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
    public class DetalleFacturaRepository : Repository<DetalleFactura>, IDetalleFacturaRepository
    {
        private readonly ApplicationDbContext _db;

        public DetalleFacturaRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<DetalleFacturaVM> GetListIngresoTipoVM(int est)
        {
            return null;
        }

        public DetalleFactura GetPagoRealizado(int idAsEs)
        {
            return new DetalleFactura();
        }

        public void Update(DetalleFactura detalleFactura)
        {
            var objDesdeDB = _db.DetalleFactura.FirstOrDefault(s => s.Id == detalleFactura.Id);
            objDesdeDB.IdFactura = detalleFactura.IdFactura;
            objDesdeDB.IdCuota = detalleFactura.IdCuota;
            objDesdeDB.Monto = detalleFactura.Monto;
            objDesdeDB.Cantidad = detalleFactura.Cantidad;

            _db.SaveChanges();
        }
    }
}
