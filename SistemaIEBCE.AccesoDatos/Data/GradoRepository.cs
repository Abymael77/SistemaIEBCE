using Microsoft.AspNetCore.Mvc.Rendering;
using SistemaIEBCE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIEBCE.AccesoDatos.Data.Repository
{
    public class GradoRepository : Repository<Grado>, IGradoRepository
    {
        private readonly ApplicationDbContext _db;

        public GradoRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetListaGrado()
        {
            return _db.Grado.Select(i => new SelectListItem()
            {
                Text = i.NomGrado,
                Value = i.Id.ToString()
            }); ;
        }

        public void Update(Grado grado)
        {
            var objDesdeDB = _db.Grado.FirstOrDefault(s => s.Id == grado.Id);
            objDesdeDB.NomGrado = grado.NomGrado;
            objDesdeDB.Estado = grado.Estado;

            _db.SaveChanges();
        }
    }
}
