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
    public interface INotaRepository :IRepository<Nota>
    {
        IEnumerable<SelectListItem> GetListaNota();
        IEnumerable<Nota> GetListaNotaBloque(int? blk);
        IEnumerable<Nota> GetListaNotaBloqueFil(int? blk);

        IEnumerable<NotaRep> GetEstDestacados(int anio, int cant);

        void Update(Nota Nota);
    }
}
