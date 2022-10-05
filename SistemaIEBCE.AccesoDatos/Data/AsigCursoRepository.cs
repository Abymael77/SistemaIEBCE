using Microsoft.AspNetCore.Mvc.Rendering;
using SistemaIEBCE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIEBCE.AccesoDatos.Data.Repository
{
    public class AsigCursoRepository : Repository<AsigCurso>, IAsigCursoRepository
    {
        private readonly ApplicationDbContext _db;

        public AsigCursoRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetListaAsigCurso()
        {
            return _db.AsigCurso.Select(i => new SelectListItem()
            {
                Text = i.Curso.NomCurso,
                Value = i.Id.ToString()
            }); ;
        }

        public IEnumerable<AsigCurso> GetListaAsigCursoEst(int est)
        {
            List<AsigCurso> list = null;

            // consulta Validada por estado 
            var query = (from ca in _db.AsigCurso
                         where ca.Estado == est
                         select new AsigCurso
                         {
                             Id = ca.Id,
                             CicloEscolar = ca.CicloEscolar
                         }).Distinct();
            list = query.ToList();

            return list;
        }

        public IEnumerable<SelectListItem> GetListaAsigCicloEscolar()
        {
            List<SelectListItem> list = null;
            int est = 1;

            // consulta Validada por estado 
            var query = (from ca in _db.CicloEscolar
                         where ca.Estado == est
                         select new SelectListItem { 
                             Text = ca.Anio.ToString() + " - " + ca.Grado.NomGrado + " - " + ca.Seccion.NomSeccion, 
                             Value = ca.Id.ToString() 
                         }).Distinct();
            list = query.ToList();

            return list;
        }

        public void Update(AsigCurso AsigCurso)
        {
            var objDesdeDB = _db.AsigCurso.FirstOrDefault(s => s.Id == AsigCurso.Id);
            objDesdeDB.IdCatedratico = AsigCurso.IdCatedratico;
            objDesdeDB.IdCurso = AsigCurso.IdCurso;
            objDesdeDB.IdCicloEscolar = AsigCurso.IdCicloEscolar;
            objDesdeDB.Estado = AsigCurso.Estado;

            _db.SaveChanges();
        }
    }
}

//AsigCurso
