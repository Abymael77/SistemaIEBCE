using Microsoft.AspNetCore.Mvc.Rendering;
using SistemaIEBCE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIEBCE.AccesoDatos.Data.Repository
{
    public interface IGradoRepository : IRepository<Grado>
    {
        IEnumerable<SelectListItem> GetListaGrado();

        void Update(Grado grado);
    }
}
