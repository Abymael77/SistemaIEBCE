using Microsoft.Extensions.Configuration;
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
        private readonly IConfiguration _conf;


        public ContenedorTrabajo(ApplicationDbContext db)
        {
            _db = db;

            Curso = new CursoRepository(_db);
            Grado = new GradoRepository(_db);
            Seccion = new SeccionRepository(_db);
            Bloque = new BloqueRepository(_db);
            Catedratico = new CatedraticoRepository(_db);
            Estudiante = new EstudianteRepository(_db);

            //Asignaciones
            CicloEscolar = new CicloEscolarRepository(_db);
            AsigCurso = new AsigCursoRepository(_db);
            AsigEstudiante = new AsigEstudianteRepository(_db);
            BloqueAsigCurso = new BloqueAsigCursoRepository(_db, _conf);
            Nota = new NotaRepository(_db);
            Asistencia = new AsistenciaRepository(_db);

            //Tesoreria
            Cuota = new CuotaRepository(_db);
            Gasto = new GastoRepository(_db);
            DetalleGasto = new DetalleGastoRepository(_db);
            Caja = new CajaRepository(_db);
            Factura = new FacturaRepository(_db);
            DetalleFactura = new DetalleFacturaRepository(_db);

            Usuario = new UsuarioRepository(_db);


        }


        public ICursoRepository Curso { get; private set; }
        public IGradoRepository Grado { get; private set; }
        public ISeccionRepository Seccion { get; private set; }
        public IBloqueRepository Bloque { get; private set; }
        public ICatedraticoRepository Catedratico { get; private set; }
        public IEstudianteRepository Estudiante { get; private set; }

        //Asignaciones
        public ICicloEscolarRepository CicloEscolar { get; private set; }
        public IAsigCursoRepository AsigCurso { get; private set; }
        public IAsigEstudianteRepository AsigEstudiante { get; private set; }
        public IBloqueAsigCursoRepository BloqueAsigCurso { get; private set; }
        public INotaRepository Nota { get; private set; }
        public IAsistenciaRepository Asistencia { get; private set; }

        //Tesoreria
        public ICuotaRepository Cuota { get; private set; }
        public IGastoRepository Gasto { get; private set; }
        public IDetalleGastoRepository DetalleGasto { get; private set; }
        public ICajaRepository Caja { get; private set; }
        public IFacturaRepository Factura { get; private set; }
        public IDetalleFacturaRepository DetalleFactura { get; private set; }


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
