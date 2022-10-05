using Microsoft.AspNetCore.Mvc.Rendering;
using SistemaIEBCE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIEBCE.AccesoDatos.Data.Repository
{
    public interface INotaRepository :IRepository<Nota>
    {
        IEnumerable<SelectListItem> GetListaNota();
        IEnumerable<Nota> GetListaNotaBloque(int? blk);
        IEnumerable<Nota> GetListaNotaBloqueFil(int? blk);

        void Update(Nota Nota);
    }
}
