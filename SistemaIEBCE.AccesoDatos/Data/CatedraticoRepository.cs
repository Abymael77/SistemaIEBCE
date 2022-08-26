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
    public class CatedraticoRepository : Repository<Catedratico>, ICatedraticoRepository
    {
        private readonly ApplicationDbContext _db;

        public CatedraticoRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetListaCatedratico()
        {
            return _db.Catedratico.Select(i => new SelectListItem()
            {
                Text = i.NomCatedratico,
                Value = i.Id.ToString()
            }); ;
        }

        public void Update(Catedratico seccion)
        {
            var objDesdeDB = _db.Catedratico.FirstOrDefault(s => s.Id == seccion.Id);
            objDesdeDB.NomCatedratico = seccion.NomCatedratico;
            objDesdeDB.ApellCatedratico = seccion.ApellCatedratico;
            objDesdeDB.Sexo = seccion.Sexo;
            objDesdeDB.Tel = seccion.Tel;
            objDesdeDB.Profesion = seccion.Profesion;
            objDesdeDB.Estado = seccion.Estado;

            _db.SaveChanges();
        }
    }
}
