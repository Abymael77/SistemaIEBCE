using Microsoft.AspNetCore.Mvc.Rendering;
using SistemaIEBCE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIEBCE.AccesoDatos.Data.Repository
{
    public interface IAsistenciaRepository :IRepository<Asistencia>
    {
        IEnumerable<SelectListItem> GetListaAsistencia();
        IEnumerable<Asistencia> GetListaAsistenciaBloque(int IdBlkAsCu, int IdCicloEscolar, string Fecha);
        IEnumerable<Asistencia> GetListaAsistenciaBloqueFil(int? blk);

        void Update(Asistencia Asistencia);
    }
}
