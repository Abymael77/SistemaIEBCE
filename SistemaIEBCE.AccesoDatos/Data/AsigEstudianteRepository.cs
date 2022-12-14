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
    public class AsigEstudianteRepository : Repository<AsigEstudiante>, IAsigEstudianteRepository
    {
        private readonly ApplicationDbContext _db;

        public AsigEstudianteRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetListaAsigEstudiante()
        {
            List<SelectListItem> list = null;
            int est = 1;

            // consulta Validada por estado 
            var query = (from es in _db.Estudiante
                         where es.Estado == est /*&& (ases.Estado == 0 || ases.Estado == null)*/
                         //join ases in _db.AsigEstudiante on es.Id equals ases.IdEstudiante
                         select new SelectListItem
                         {
                             Text =  es.ApellEstudiante + " , " + es.NomEstudiante,
                             Value = es.Id.ToString()
                         }).Distinct();
            list = query.ToList();

            return list; ;
        }

        public IEnumerable<AsigEstudianteVM> GetListaAsigEstCuclo(int anio)
        {
            List<AsigEstudianteVM> list = null;

            // consulta Validada por estado 
            var query = (from ases in _db.AsigEstudiante
                         join es in _db.Estudiante on ases.IdEstudiante equals es.Id
                         join cies in _db.CicloEscolar on ases.IdCicloEscolar equals cies.Id
                         join gr in _db.Grado on cies.IdGrado equals gr.Id
                         join se in _db.Seccion on cies.IdSeccion equals se.Id
                         where cies.Anio == anio
                         select new AsigEstudianteVM
                         {
                             id = ases.Id,
                             idEstu = es.Id,
                             nombres = es.NomEstudiante,
                             apellidos = es.ApellEstudiante,
                             cicloEscolar = gr.NomGrado + " - " + se.NomSeccion + " - " + cies.Anio,
                             estado = ases.Estado
                         }).Distinct();
            list = query.ToList();

            return list; ;
        }

        public IEnumerable<NotaAllVM> GetListaAsigEstudianteCiclo(int? IdBlkAsCu, int? est, int IdCicloEscolar, int IdAsigCurso)
        {
            List<NotaAllVM> list = null;

            // consulta Validada por estado 
            var query = (from nt in _db.Nota
                         join ases in _db.AsigEstudiante on nt.IdAsigEstudinate equals ases.Id
                         join es in _db.Estudiante on ases.IdEstudiante equals es.Id
                         where nt.asigEstudiante.Estado == est && nt.IdBloqueAsigCurso == IdBlkAsCu && ases.IdCicloEscolar == IdCicloEscolar && nt.BloqueAsigCurso.IdAsigCurso == IdAsigCurso
                         select new NotaAllVM
                         {
                             Nota = nt,
                             Estudiante = es
                             
                         }).Distinct();

            //// consulta Validada por estado 
            //var query = (from es in _db.AsigEstudiante
            //             where es.Estado == est && es.IdCicloEscolar == IdCiclo /*&& (ases.Estado == 0 || ases.Estado == null)*/
            //             //join ases in _db.AsigEstudiante on es.Id equals ases.IdEstudiante
            //             select new AsigEstudiante
            //             {
            //                 Estudiante = es.Estudiante,
            //                 Id = es.Id
            //             }).Distinct();

            list = query.ToList();

            return list; ;
        }

        public IEnumerable<AsigEstudiante> GetListaAsigEstCiclo(int? IdCiclo)
        {
            List<AsigEstudiante> list = null;

            // consulta Validada por estado 
            var query = (from es in _db.AsigEstudiante
                         where es.IdCicloEscolar == IdCiclo /*&& (ases.Estado == 0 || ases.Estado == null)*/
                         //join ases in _db.AsigEstudiante on es.Id equals ases.IdEstudiante
                         select new AsigEstudiante
                         {
                             Id = es.Id,
                             Estudiante = es.Estudiante,
                         }).Distinct();
            list = query.ToList();

            return list; ;
        }

        public IEnumerable<Nota> GetListaNota(int? IdCiclo, int? est)
        {
            List<Nota> list = null;

            // consulta Validada por estado 
            var query = (from es in _db.Nota
                         where es.asigEstudiante.Estado == est && es.asigEstudiante.IdCicloEscolar == IdCiclo /*&& (ases.Estado == 0 || ases.Estado == null)*/
                         //join ases in _db.AsigEstudiante on es.Id equals ases.IdEstudiante
                         select new Nota
                         {
                             asigEstudiante = es.asigEstudiante,
                             Punteo = es.Punteo,
                             BloqueAsigCurso = es.BloqueAsigCurso

                         }).Distinct();
            list = query.ToList();

            return list; ;
        }

        //Notas por bloque
        public IEnumerable<NotaFull> GetListaNotaBlk(int idAsigEstudinate, int idBloque)
        {
            List<NotaFull> list = null;

            // consulta Validada por estado 
            var query = (from nt in _db.Nota
                         where nt.asigEstudiante.Id == idAsigEstudinate && nt.BloqueAsigCurso.Bloque.Id == idBloque
                         join ases in _db.AsigEstudiante on nt.IdAsigEstudinate equals ases.Id
                         join es in _db.Estudiante on ases.IdEstudiante equals es.Id
                         select new NotaFull
                         {
                             Id = nt.Id,
                             IdAsigEstudinate = nt.IdAsigEstudinate,
                             IdBloqueAsigCurso = nt.IdBloqueAsigCurso,
                             Punteo = nt.Punteo,
                             asigEstudiante = nt.asigEstudiante,
                             Estudiante = nt.asigEstudiante.Estudiante,
                             BloqueAsigCurso = nt.BloqueAsigCurso,
                             Bloque = nt.BloqueAsigCurso.Bloque,
                             Curso = nt.BloqueAsigCurso.AsigCurso.Curso

                         }).Distinct();
            list = query.ToList();

            return list; ;
        }

        //Notas por Completa Con promedio
        public IEnumerable<NotaFull> GetListaNotaPromedio(int idAsigEstudinate)
        {
            List<NotaFull> list = null;

            // consulta Validada por estado 
            var query = (from nt in _db.Nota
                         join ases in _db.AsigEstudiante on nt.IdAsigEstudinate equals ases.Id
                         join blascu in _db.BloqueAsigCurso on nt.IdBloqueAsigCurso equals blascu.Id
                         join bl in _db.Bloque on blascu.IdBloque equals bl.Id
                         join ascu in _db.AsigCurso on blascu.IdAsigCurso equals ascu.Id
                         join es in _db.Estudiante on ases.IdEstudiante equals es.Id
                         orderby ascu.Id descending
                         where nt.asigEstudiante.Id == idAsigEstudinate
                         select new NotaFull
                         {
                             Id = nt.Id,
                             IdAsigEstudinate = nt.IdAsigEstudinate,
                             IdBloqueAsigCurso = nt.IdBloqueAsigCurso,
                             Punteo = nt.Punteo,
                             Bloque = nt.BloqueAsigCurso.Bloque,
                             Curso = nt.BloqueAsigCurso.AsigCurso.Curso

                         });
            list = query.ToList();

            return list; ;
        }

        //Bloque del estudiante
        public IEnumerable<SelectListItem> GetListaBloque(int idAsigEstudinate)
        {
            List<SelectListItem> list = null;

            // consulta Validada por estado 
            var query = (from nt in _db.Nota
                         where nt.asigEstudiante.Id == idAsigEstudinate
                         join ases in _db.AsigEstudiante on nt.IdAsigEstudinate equals ases.Id
                         join blascu in _db.BloqueAsigCurso on nt.IdBloqueAsigCurso equals blascu.Id
                         join bl in _db.Bloque on blascu.IdBloque equals bl.Id
                         orderby bl.Id ascending
                         select new SelectListItem
                         {
                             Text = bl.NomBloque,
                             Value = bl.Id.ToString()

                         }).Distinct();
            list = query.ToList();

            return list; ;
        }

        //Cursos del estudiante
        public IEnumerable<SelectListItem> GetListaCurso(int idAsigEstudinate)
        {
            List<SelectListItem> list = null;

            // consulta Validada por estado 
            var query = (from nt in _db.Nota
                         where nt.asigEstudiante.Id == idAsigEstudinate
                         join ases in _db.AsigEstudiante on nt.IdAsigEstudinate equals ases.Id
                         join blascu in _db.BloqueAsigCurso on nt.IdBloqueAsigCurso equals blascu.Id
                         join ascu in _db.AsigCurso on blascu.IdAsigCurso equals ascu.Id
                         join cu in _db.Curso on ascu.IdCurso equals cu.Id
                         orderby cu.Id ascending
                         select new SelectListItem
                         {
                             Text = cu.NomCurso,
                             Value = cu.Id.ToString()

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

        //Tesoreria ######################################################################################################

        public IEnumerable<AsigEstudianteVM> GetListaAsigEstudianteCiclActivo(int est)
        {
            List<AsigEstudianteVM> list = null; 

            // consulta Validada por estado 
            var query = (from ases in _db.AsigEstudiante
                         join es in _db.Estudiante on ases.IdEstudiante equals es.Id
                         where ases.Estado == est
                         select new AsigEstudianteVM
                         { 
                             AsigEstudiante = ases,
                         }).Distinct();
            list = query.ToList();

            return list;
        }

        public void Update(AsigEstudiante AsigEstudiante)
        {
            var objDesdeDB = _db.AsigEstudiante.FirstOrDefault(s => s.Id == AsigEstudiante.Id);
            objDesdeDB.IdEstudiante = AsigEstudiante.IdEstudiante;
            objDesdeDB.IdCicloEscolar = AsigEstudiante.IdCicloEscolar;
            objDesdeDB.Estado = AsigEstudiante.Estado;

            _db.SaveChanges();
        }
    }
}

//AsigEstudiante
