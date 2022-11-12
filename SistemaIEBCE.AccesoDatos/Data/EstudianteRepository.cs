using Microsoft.AspNetCore.Mvc.Rendering;
using SistemaIEBCE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIEBCE.AccesoDatos.Data.Repository
{
    public class EstudianteRepository : Repository<Estudiante>, IEstudianteRepository
    {
        private readonly ApplicationDbContext _db;

        public EstudianteRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetListaEstudiante()
        {
            List<SelectListItem> list = null;
            int est = 1;

            // consulta Validada por estado 
            var query = (from ca in _db.Estudiante
                         where ca.Estado == est
                         select new SelectListItem { 
                             Text = ca.NomEstudiante + " " + ca.ApellEstudiante, 
                             Value = ca.Id.ToString() 
                         }).Distinct();
            list = query.ToList();

            return list;
        }

        public void Update(Estudiante seccion)
        {
            var objDesdeDB = _db.Estudiante.FirstOrDefault(s => s.Id == seccion.Id);
            objDesdeDB.NomEstudiante = seccion.NomEstudiante;
            objDesdeDB.ApellEstudiante = seccion.ApellEstudiante;
            objDesdeDB.Sexo = seccion.Sexo;
            objDesdeDB.Carnet = seccion.Carnet;
            objDesdeDB.TelEstudiante = seccion.TelEstudiante;
            objDesdeDB.Encargado = seccion.Encargado;
            objDesdeDB.TelEncargado = seccion.TelEncargado;
            objDesdeDB.Direccion = seccion.Direccion;
            objDesdeDB.Estado = seccion.Estado;

            _db.SaveChanges();
        }

        IEnumerable<SelectListItem> IEstudianteRepository.GetListaEstudiante()
        {
            throw new NotImplementedException();
        }
    }
}
