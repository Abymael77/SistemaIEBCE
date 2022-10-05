using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using SistemaIEBCE.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIEBCE.AccesoDatos.Data.Repository
{
    public class BloqueAsigCursoRepository : Repository<BloqueAsigCurso>, IBloqueAsigCursoRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IConfiguration configuration;

        public BloqueAsigCursoRepository(ApplicationDbContext db, IConfiguration _configuration) : base(db)
        {
            _db = db;
            configuration = _configuration;
        }

        public IEnumerable<SelectListItem> GetListaAsigCurso()
        {
            return _db.AsigCurso.Select(i => new SelectListItem()
            {
                Text = i.Curso.NomCurso,
                Value = i.Id.ToString()
            }); ;
        }

        public IEnumerable<BloqueAsigCurso> GetListaBloqueCurso(int? id)
        {
            List<BloqueAsigCurso> list = null;

            // consulta Validada por estado 
            var query = (from ca in _db.BloqueAsigCurso
                         where ca.Id == id
                         select new BloqueAsigCurso { 
                             Id = ca.Id,
                             AsigCurso = ca.AsigCurso,
                             IdBloque = ca.IdBloque,
                             IdAsigCurso = ca.IdAsigCurso,
                             Estado = ca.Estado,
                             Bloque = ca.Bloque,
                         }).Distinct();
            list = query.ToList();

            return list;
        }
        
        public IEnumerable<BloqueAsigCurso> GetListaBloqueAsCu(int curso)
        {
            List<BloqueAsigCurso> list = null;

            // consulta Validada por estado 
            var query = (from ca in _db.BloqueAsigCurso
                         where ca.IdAsigCurso == curso
                         select new BloqueAsigCurso {  
                             Bloque = ca.Bloque, 
                             AsigCurso = ca.AsigCurso,
                             Id = ca.Id }).Distinct();
            list = query.ToList();

            return list;
        }
        
        //3liminar
        public DataTable GetListaBloque(int idCicEs)
        {
            var conn = configuration.GetValue<string>("ConnectionStrings:conSQL2");
            SqlDataAdapter da = new SqlDataAdapter("SELECT bl.Id, bl.NomBloque, ascu.IdCicloEscolar FROM BloqueAsigCurso AS blascu INNER JOIN Bloque AS bl  On bl.Id = blascu.IdBloque INNER JOIN AsigCurso AS ascu ON ascu.Id = blascu.IdAsigCurso WHERE ascu.IdCicloEscolar = " + idCicEs +" GROUP BY bl.Id, bl.NomBloque, ascu.IdCicloEscolar", conn);


            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
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
