using Microsoft.AspNetCore.Mvc.Rendering;
using SistemaIEBCE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIEBCE.AccesoDatos.Data.Repository
{
    public interface ICajaRepository : IRepository<Caja>
    {
        IEnumerable<Caja> CajaActiva(int est);

        void Update(Caja caja);
    }
}
