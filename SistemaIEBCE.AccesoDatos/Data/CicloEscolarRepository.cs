    using Microsoft.AspNetCore.Mvc.Rendering;
using SistemaIEBCE.Models;
using SistemaIEBCE.Models.ViewModels;
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

        public IEnumerable<CicloEscolar> GetListaCicloEscolar()
        {
            List<CicloEscolar> list = null;

            // consulta Validada por estado 
            var query = (from cies in _db.CicloEscolar
                         group new { cies.Anio, cies.Estado} by cies.Anio into cic
                         select new CicloEscolar { 
                             Anio = cic.Max(c => c.Anio),
                             Estado = cic.Max(c => c.Estado)
                         }).Distinct();
            list = query.ToList();

            return list;
        }

        public IEnumerable<CicloEscolar> GetListaCicloEscolarEst(int est)
        {
            List<CicloEscolar> list = null;

            // consulta Validada por estado 
            var query = (from cies in _db.CicloEscolar
                         where cies.Estado == est
                         group new { cies.Anio, cies.Estado} by cies.Anio into cic
                         select new CicloEscolar { 
                             Anio = cic.Max(c => c.Anio),
                             Estado = cic.Max(c => c.Estado)
                         }).Distinct();
            list = query.ToList();

            return list;
        }

        public IEnumerable<RepCiEsVM> GetListaAsEs(int est)
        {
            List<RepCiEsVM> list = null;

            // consulta Validada por estado 
            var query = (from ases in _db.AsigEstudiante
                         join es in _db.Estudiante on ases.IdEstudiante equals es.Id
                         join cies in _db.CicloEscolar on ases.IdCicloEscolar equals cies.Id
                         join gr in _db.Grado on cies.IdGrado equals gr.Id
                         join se in _db.Seccion on cies.IdSeccion equals se.Id
                         //group new { ases.Estado, ases.Id} by ases.Estado into repes
                         //where ases.Estado == est
                         select new RepCiEsVM
                         { 
                             AsigEstudiante = ases,
                             gradoAs = gr,
                             SeccionAs = se,
                             CantX = ases.IdCicloEscolar
                         }).Distinct();
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
