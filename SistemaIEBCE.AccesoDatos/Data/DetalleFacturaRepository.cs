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

        public IEnumerable<DetalleFacturaVM> GetListIngresoTipoVM(int idCaja)
        {
            //hay que arreglar no se que hace 
            List<DetalleFacturaVM> list = null;

            // consulta Validada por estado 
            var query = (from defa in _db.DetalleFactura
                         join fa in _db.Factura on defa.IdFactura equals fa.Id
                         join cu in _db.Cuota on defa.IdCuota equals cu.Id
                         where fa.IdCaja == idCaja
                         group new { defa.IdCuota, cu.NomCuota, defa.Monto, defa.Cantidad } by defa.IdCuota into ingres
                         select new DetalleFacturaVM
                         {
                             IdCuota = Convert.ToInt32(ingres.Max(c => c.IdCuota)),
                             NomCuota = ingres.Max(n => n.NomCuota),
                             Monto = ingres.Sum(m => m.Monto),
                             Cantidad = ingres.Sum(c => c.Cantidad)
                         }).ToList();
            list = query;

            return list;
        }

        public IEnumerable<DetalleFactura> GetPagoRealizado(int idAsEs)
        {
            //obtener el pago lso pagos ya realizados por el estudiantes
            //para mostrarlos en el alert de factura
            List<DetalleFactura> list = null;

            // consulta Validada por estado 
            var query = (from defa in _db.DetalleFactura
                         join fa in _db.Factura on defa.IdFactura equals fa.Id
                         join cu in _db.Cuota on defa.IdCuota equals cu.Id
                         where fa.IdAsigEstudiante == idAsEs
                         group new { cu.Id, defa.Cantidad } by cu.Id into Deta
                         select new DetalleFactura
                         {
                             IdCuota = Deta.Key,
                             Cantidad = Deta.Sum( c => c.Cantidad)
                         }).Distinct();
            list = query.ToList();

            return list;
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
