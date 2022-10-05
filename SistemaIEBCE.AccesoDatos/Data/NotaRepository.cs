using Microsoft.AspNetCore.Mvc.Rendering;
using SistemaIEBCE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIEBCE.AccesoDatos.Data.Repository
{
    public class NotaRepository : Repository<Nota>, INotaRepository
    {
        private readonly ApplicationDbContext _db;

        public NotaRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetListaNota()
        {
            return _db.Nota.Select(i => new SelectListItem()
            {
                Text = i.asigEstudiante.Estudiante.NomEstudiante,
                Value = i.Id.ToString()
            }); ;
        }

        public IEnumerable<Nota> GetListaNotaBloque(int? blk)
        {
            List<Nota> list = null;

            // consulta Validada por estado 
            var query = (from ca in _db.Nota
                         where ca.IdBloqueAsigCurso == blk
                         select new Nota { 
                             asigEstudiante =  ca.asigEstudiante,
                             BloqueAsigCurso = ca.BloqueAsigCurso,
                         }).Distinct();
            list = query.ToList();

            return list;
        }

        public IEnumerable<Nota> GetListaNotaBloqueFil(int? blk)
        {
            List<Nota> list = null;

            // consulta Validada por estado 
            var query = (from ca in _db.Nota
                         where ca.IdBloqueAsigCurso == blk
                         select new Nota { 
                             Id = ca.Id,
                             BloqueAsigCurso = ca.BloqueAsigCurso,
                             Punteo = ca.Punteo
                         }).Distinct();
            list = query.ToList();

            return list;
        }

        public void Update(Nota Nota)
        {
            var objDesdeDB = _db.Nota.FirstOrDefault(s => s.Id == Nota.Id);
            objDesdeDB.Punteo = Nota.Punteo;
            objDesdeDB.IdAsigEstudinate = Nota.IdAsigEstudinate;
            objDesdeDB.IdBloqueAsigCurso = Nota.IdBloqueAsigCurso;

            _db.SaveChanges();
        }
    }
}

//Nota
