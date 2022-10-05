using Microsoft.AspNetCore.Mvc.Rendering;
using SistemaIEBCE.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIEBCE.AccesoDatos.Data.Repository
{
    public interface IBloqueAsigCursoRepository : IRepository<BloqueAsigCurso>
    {
        IEnumerable<SelectListItem> GetListaAsigCurso();

        IEnumerable<BloqueAsigCurso> GetListaBloqueCurso(int? id);

        IEnumerable<BloqueAsigCurso> GetListaBloqueAsCu(int curso);
        
        //Retornar una sola coicidencia de todos los bloques asignados en cada curso para imprirmir la boleta
        DataTable GetListaBloque(int idCicEs);



        void Update(AsigCurso AsigCurso);
    }
}
