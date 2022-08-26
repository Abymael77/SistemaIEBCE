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


        IUsuarioRepository Usuario { get; }


        void Save();
    }
}
