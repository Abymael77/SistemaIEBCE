using Microsoft.AspNetCore.Mvc.Rendering;
using SistemaIEBCE.AccesoDatos.Data.Repository;
using SistemaIEBCE.Models;
using SistemaIEBCE.Models.ViewModels;
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

        public IEnumerable<DetaFacVM> GetDetFacEstud(int IdFactura)
        {
            //hay que arreglar no se que hace 
            List<DetaFacVM> list = null;

            // consulta Validada por estado 
            var query = (from defa in _db.DetalleFactura
                         join fa in _db.Factura on defa.IdFactura equals fa.Id
                         join cu in _db.Cuota on defa.IdCuota equals cu.Id
                         join ases in _db.AsigEstudiante on fa.IdAsigEstudiante equals ases.Id
                         join es in _db.Estudiante on ases.IdEstudiante equals es.Id
                         join cies in _db.CicloEscolar on ases.IdCicloEscolar equals cies.Id
                         join se in _db.Seccion on cies.IdSeccion equals se.Id
                         join gr in _db.Grado  on cies.IdGrado equals gr.Id
                         where defa.IdFactura == IdFactura
                         select new DetaFacVM
                         {
                             Cuota = cu,
                             Factura = fa,
                             Estudiante = es,
                             DetalleFactura = defa,
                             Grado = gr,
                             Seccion = se

                         }).ToList();
            list = query;

            return list;
        }

        //devolcer suma total de cuotas agrupoadas por tipo
        public IEnumerable<DetalleFacturaVM> GetListIngresoTipoVM(int idCaja)
        {
            //hay que arreglar no se que hace 
            List<DetalleFacturaVM> list = null;

            // consulta Validada por estado 
            var query = (from defa in _db.DetalleFactura
                         join fa in _db.Factura on defa.IdFactura equals fa.Id
                         join cu in _db.Cuota on defa.IdCuota equals cu.Id
                         where fa.IdCaja == idCaja
                         group new { defa.IdCuota, fa.IdCaja,cu.NomCuota, defa.Monto, defa.Cantidad } by defa.IdCuota into ingres
                         select new DetalleFacturaVM
                         {
                             IdCaja = ingres.Max(c => c.IdCaja),
                             IdCuota = Convert.ToInt32(ingres.Max(c => c.IdCuota)),
                             NomCuota = ingres.Max(n => n.NomCuota),
                             Monto = ingres.Sum(m => m.Monto*m.Cantidad),
                             Cantidad = ingres.Sum(c => c.Cantidad)
                         }).ToList();
            list = query;

            return list;
        }

        public IEnumerable<DetalleFacturaVM> GetListIngresoTipoVMVer(int idCaja, int idCuota)
        {
            //hay que arreglar no se que hace 
            List<DetalleFacturaVM> list = null;

            // consulta Validada por estado 
            var query = (from defa in _db.DetalleFactura
                         join fa in _db.Factura on defa.IdFactura equals fa.Id
                         join cu in _db.Cuota on defa.IdCuota equals cu.Id
                         where fa.IdCaja == idCaja && cu.Id == idCuota
                         select new DetalleFacturaVM
                         {
                             Factura = fa,
                             IdCuota = cu.Id,
                             NomCuota = cu.NomCuota,
                             Monto = defa.Monto,
                             Cantidad = defa.Cantidad,
                             
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
