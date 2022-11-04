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
    public interface ICicloEscolarRepository :IRepository<CicloEscolar>
    {
        IEnumerable<CicloEscolar> GetListaCicloEscolar();

        IEnumerable<CicloEscolar> GetListaCicloEscolarEst(int est);

        IEnumerable<RepCiEsVM> GetListaAsEs(int est);

        void Update(CicloEscolar cicloEscolar);
    }
}
