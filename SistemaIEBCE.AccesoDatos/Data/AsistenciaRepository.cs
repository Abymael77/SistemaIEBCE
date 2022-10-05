using Microsoft.AspNetCore.Mvc.Rendering;
using SistemaIEBCE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIEBCE.AccesoDatos.Data.Repository
{
    public class AsistenciaRepository : Repository<Asistencia>, IAsistenciaRepository
    {
        private readonly ApplicationDbContext _db;

        public AsistenciaRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetListaAsistencia()
        {
            return _db.Asistencia.Select(i => new SelectListItem()
            {
                Text = i.asigEstudiante.Estudiante.NomEstudiante,
                Value = i.Id.ToString()
            }); ;
        }

        public IEnumerable<Asistencia> GetListaAsistenciaBloque(int IdBlkAsCu, int IdCicloEscolar, string Fecha)
        {
            List<Asistencia> list = null;

            //consulta Validada por estado
            var query = (from asis in _db.Asistencia
                         join ases in _db.AsigEstudiante on asis.IdAsigEstudinate equals ases.Id
                         join es in _db.Estudiante on asis.IdAsigEstudinate equals es.Id
                         where asis.IdBloqueAsigCurso == IdBlkAsCu && asis.Fecha == Convert.ToDateTime(Fecha)
                         select new Asistencia
                         {
                             Id = asis.Id,
                             asigEstudiante = asis.asigEstudiante,
                             BloqueAsigCurso = asis.BloqueAsigCurso,
                         }).Distinct();

            // consulta Validada por fecha 
            //var query = from asis in _db.Asistencia
            //             where asis.IdBloqueAsigCurso == blk
            //             group asis by asis into lstAsis
            //             select lstAsis;

            list = query.ToList();

            return list;
        }

        public IEnumerable<Asistencia> GetListaAsistenciaBloqueFil(int? blk)
        {
            List<Asistencia> list = null;

            // consulta Validada por estado 
            var query = (from ca in _db.Asistencia
                         where ca.IdBloqueAsigCurso == blk
                         select new Asistencia { 
                             Id = ca.Id,
                             BloqueAsigCurso = ca.BloqueAsigCurso
                         }).Distinct();
            list = query.ToList();

            return list;
        }

        public void Update(Asistencia Asistencia)
        {
            var objDesdeDB = _db.Asistencia.FirstOrDefault(s => s.Id == Asistencia.Id);
            objDesdeDB.Fecha = Asistencia.Fecha;
            objDesdeDB.Tipo = Asistencia.Tipo;
            objDesdeDB.Comentario = Asistencia.Comentario;
            objDesdeDB.IdAsigEstudinate = Asistencia.IdAsigEstudinate;
            objDesdeDB.IdBloqueAsigCurso = Asistencia.IdBloqueAsigCurso;

            _db.SaveChanges();
        }
    }
}

//Asistencia
