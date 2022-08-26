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
    public class SeccionRepository : Repository<Seccion>, ISeccionRepository
    {
        private readonly ApplicationDbContext _db;

        public SeccionRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetListaSeccion()
        {
            return _db.Seccion.Select(i => new SelectListItem()
            {
                Text = i.NomSeccion,
                Value = i.Id.ToString()
            }); ;
        }

        public void Update(Seccion seccion)
        {
            var objDesdeDB = _db.Seccion.FirstOrDefault(s => s.Id == seccion.Id);
            objDesdeDB.NomSeccion = seccion.NomSeccion;
            objDesdeDB.Estado = seccion.Estado;

            _db.SaveChanges();
        }
    }
}
