using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIEBCE.AccesoDatos.Data.Repository
{
    public interface IContenedorTrabajo : IDisposable
    {
        ICursoRepository Curso { get; }
        IGradoRepository Grado { get; }
        ISeccionRepository Seccion { get; }
        IBloqueRepository Bloque { get; }
        ICatedraticoRepository Catedratico { get; }
        IEstudianteRepository Estudiante { get; }

        //Asignaciones
        ICicloEscolarRepository CicloEscolar { get; }
        IAsigCursoRepository AsigCurso { get; }
        IAsigEstudianteRepository AsigEstudiante { get; }
        IBloqueAsigCursoRepository BloqueAsigCurso { get; }
        INotaRepository Nota { get; }
        IAsistenciaRepository Asistencia { get; }

        //Tesoreria
        ICuotaRepository Cuota { get; }
        IGastoRepository Gasto { get; }
        IDetalleGastoRepository DetalleGasto { get; }
        ICajaRepository Caja { get; }
        IFacturaRepository Factura { get; }
        IDetalleFacturaRepository DetalleFactura { get; }


        IUsuarioRepository Usuario { get; }


        void Save();
    }
}
