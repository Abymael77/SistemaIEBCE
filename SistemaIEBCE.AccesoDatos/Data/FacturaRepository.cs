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
    public class FacturaRepository : Repository<Factura>, IFacturaRepository
    {
        private readonly ApplicationDbContext _db;

        public FacturaRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        
        public IEnumerable<FacturaVM> GetAllFactura()
        {
            List<FacturaVM> list = null;

            // consulta Validada por estado 
            var query = (from fa in _db.Factura
                         join ases in _db.AsigEstudiante on fa.IdAsigEstudiante equals ases.Id
                         join es in _db.Estudiante on ases.IdEstudiante equals es.Id
                         select new FacturaVM
                         {
                             Factura = fa,
                             EstLstFact = es
                             ///Arreglar factura 
                             /////debe retornar la ultima factura registrada
                         }).Distinct();
            list = query.ToList();

            return list; 
        }
        
        public Factura GetFacturaUltimo()
        {
            Factura list = null;

            // consulta Validada por estado 
            var query = (from fa in _db.Factura
                         orderby fa.Id descending
                         select new Factura
                         {
                             Id = fa.Id,
                             IdAsigEstudiante = fa.IdAsigEstudiante,
                             IdCaja = fa.IdCaja,
                             NoFactura = fa.NoFactura,
                             Fecha = fa.Fecha
                             ///Arreglar factura 
                             /////debe retornar la ultima factura registrada
                         }).FirstOrDefault();
            list = query;

            return list; 
        }

        public void Update(Factura factura)
        {
            var objDesdeDB = _db.Factura.FirstOrDefault(s => s.Id == factura.Id);
            objDesdeDB.IdCaja = factura.IdCaja;
            objDesdeDB.IdAsigEstudiante = factura.IdAsigEstudiante;
            objDesdeDB.Fecha = factura.Fecha;
            objDesdeDB.NoFactura = factura.NoFactura;

            _db.SaveChanges();
        }
    }
}
