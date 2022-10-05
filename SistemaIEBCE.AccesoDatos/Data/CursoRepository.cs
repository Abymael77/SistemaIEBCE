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
    public class CursoRepository : Repository<Curso>, ICursoRepository
    {
        private readonly ApplicationDbContext _db;

        public CursoRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetListaCurso()
        {
            List<SelectListItem> list = null;
            int est = 1;

            // consulta Validada por estado 
            var query = (from ca in _db.Curso
                         where ca.Estado == est
                         select new SelectListItem { Text = ca.NomCurso, Value = ca.Id.ToString() }).Distinct();
            list = query.ToList();

            return list;
        }

        public void Update(Curso curso)
        {
            var objDesdeDB = _db.Curso.FirstOrDefault(s => s.Id == curso.Id);
            objDesdeDB.NomCurso = curso.NomCurso;
            objDesdeDB.Descripcion = curso.Descripcion;
            objDesdeDB.Estado = curso.Estado;

            _db.SaveChanges();
        }
    }
}
