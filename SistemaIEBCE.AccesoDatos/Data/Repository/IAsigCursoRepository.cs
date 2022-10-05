using Microsoft.AspNetCore.Mvc.Rendering;
using SistemaIEBCE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIEBCE.AccesoDatos.Data.Repository
{
    public interface IAsigCursoRepository :IRepository<AsigCurso>
    {
        IEnumerable<SelectListItem> GetListaAsigCurso();
        IEnumerable<AsigCurso> GetListaAsigCursoEst(int est);
        IEnumerable<SelectListItem> GetListaAsigCicloEscolar();

        void Update(AsigCurso AsigCurso);
    }
}
