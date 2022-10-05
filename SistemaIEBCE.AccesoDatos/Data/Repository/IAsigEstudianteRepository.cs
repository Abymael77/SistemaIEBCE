using Microsoft.AspNetCore.Mvc.Rendering;
using SistemaIEBCE.Models;
using SistemaIEBCE.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIEBCE.AccesoDatos.Data.Repository
{
    public interface IAsigEstudianteRepository : IRepository<AsigEstudiante>
    {
        IEnumerable<SelectListItem> GetListaAsigEstudiante();
        IEnumerable<SelectListItem> GetListaAsigCicloEscolar();

        IEnumerable<NotaAllVM> GetListaAsigEstudianteCiclo(int? IdCiclo, int? est, int IdCicloEscolar, int IdAsigCurso);
        IEnumerable<AsigEstudiante> GetListaAsigEstCiclo(int? IdCiclo);
        IEnumerable<Nota> GetListaNota(int? IdCiclo, int? est);

        IEnumerable<NotaFull> GetListaNotaBlk(int idAsigEstudinate, int idBloque);


        void Update(AsigEstudiante AsigEstudiante);
    }
}
