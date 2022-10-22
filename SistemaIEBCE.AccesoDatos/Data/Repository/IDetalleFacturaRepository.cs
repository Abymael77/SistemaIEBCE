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
    public interface IDetalleFacturaRepository : IRepository<DetalleFactura>
    {
        IEnumerable<DetalleFacturaVM> GetListIngresoTipoVM(int idCaja);

        IEnumerable<DetalleFacturaVM> GetListIngresoTipoVMVer(int idCaja, int idCuota);

        IEnumerable<DetalleFactura> GetPagoRealizado(int idAsEs);

        IEnumerable<DetaFacVM> GetDetFacEstud(int IdFactura);

        void Update(DetalleFactura detalleFactura);
    }
}
