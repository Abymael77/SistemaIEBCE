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
            return _db.Bloque.Select(i => new SelectListItem()
            {
                Text = i.NomBloque,
                Value = i.Id.ToString()
            }); ;
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
