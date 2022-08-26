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
            return _db.Curso.Select(i => new SelectListItem()
            {
                Text = i.NomCurso,
                Value = i.Id.ToString()
            }); ;
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
