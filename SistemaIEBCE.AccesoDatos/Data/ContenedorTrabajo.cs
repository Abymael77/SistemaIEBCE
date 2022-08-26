using SistemaIEBCE.AccesoDatos.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIEBCE.AccesoDatos.Data
{
    public class ContenedorTrabajo : IContenedorTrabajo
    {
        private readonly ApplicationDbContext _db;

        public ContenedorTrabajo(ApplicationDbContext db)
        {
            _db = db;

            Curso = new CursoRepository(_db);
            Grado = new GradoRepository(_db);
            Seccion = new SeccionRepository(_db);
            Bloque = new BloqueRepository(_db);
            Catedratico = new CatedraticoRepository(_db);
            Estudiante = new EstudianteRepository(_db);

            Usuario = new UsuarioRepository(_db);


        }


        public ICursoRepository Curso { get; private set; }
        public IGradoRepository Grado { get; private set; }
        public ISeccionRepository Seccion { get; private set; }
        public IBloqueRepository Bloque { get; private set; }
        public ICatedraticoRepository Catedratico { get; private set; }
        public IEstudianteRepository Estudiante { get; private set; }



        public IUsuarioRepository Usuario { get; private set; }


        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
