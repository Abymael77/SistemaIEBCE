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

        public IEnumerable<NotaRep> GetEstDestacados(int anio, int cant)
        {
            List<NotaRep> list = null;

            // consulta Validada por estado 
            var query = (from nt in _db.Nota
                         join ases in _db.AsigEstudiante on nt.IdAsigEstudinate equals ases.Id
                         join cies in _db.CicloEscolar on ases.IdCicloEscolar equals cies.Id
                         join gr in _db.Grado on cies.IdGrado equals gr.Id
                         join se in _db.Seccion on cies.IdSeccion equals se.Id
                         join es in _db.Estudiante on ases.IdEstudiante equals es.Id
                         where cies.Anio == anio
                         group new { nt.IdAsigEstudinate, es.NomEstudiante, es.ApellEstudiante, es.Sexo, gr.NomGrado, se.NomSeccion, nt.Punteo } by nt.IdAsigEstudinate into NotaEst
                         select new NotaRep
                         {
                             IdAsigEstudinate = NotaEst.Max(n => n.IdAsigEstudinate),
                             NomEstudiante = NotaEst.Max(e => e.NomEstudiante),
                             ApellEstudiante = NotaEst.Max(e => e.ApellEstudiante),
                             Sexo = NotaEst.Max(e => e.Sexo),
                             NomGrado = NotaEst.Max(g => g.NomGrado),
                             NomSeccion = NotaEst.Max(s => s.NomSeccion),
                             Nota = NotaEst.Average(n => n.Punteo)
                         }).ToList();
            list = query;

            return list.OrderByDescending(n => n.Nota).Take(cant);
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
