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
    public class BloqueRepository : Repository<Bloque>, IBloqueRepository
    {
        private readonly ApplicationDbContext _db;

        public BloqueRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetListaBloque()
        {
            List<SelectListItem> list = null;
            int est = 1;

            // consulta Validada por estado 
            var query = (from ca in _db.Bloque
                         where ca.Estado == est
                         select new SelectListItem { 
                             Text = ca.NomBloque, 
                             Value = ca.Id.ToString()
                         }).Distinct();
            list = query.ToList();

            return list;
        }

        public IEnumerable<BloqueAsigCurso> GetListaBloqueEstado(int est) 
        {
            List<BloqueAsigCurso> list = null;

            // consulta Validada por estado 
            var query = (from ca in _db.BloqueAsigCurso
                         where ca.Estado == est
                         select new BloqueAsigCurso { Bloque = ca.Bloque, Id = ca.Id }).Distinct();
            list = query.ToList();

            return list;
        }

        public void Update(Bloque seccion)
        {
            var objDesdeDB = _db.Bloque.FirstOrDefault(s => s.Id == seccion.Id);
            objDesdeDB.NomBloque = seccion.NomBloque;
            objDesdeDB.Estado = seccion.Estado;

            _db.SaveChanges();
        }
    }
}
