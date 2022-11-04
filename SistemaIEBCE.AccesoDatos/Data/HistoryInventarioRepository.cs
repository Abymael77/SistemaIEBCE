using Microsoft.AspNetCore.Mvc.Rendering;
using SistemaIEBCE.AccesoDatos.Data.Repository;
using SistemaIEBCE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIEBCE.AccesoDatos.Data
{
    public class HistoryInventarioRepository : Repository<HistoryInventario>, IHistoryInventarioRepository
    {
        private readonly ApplicationDbContext _db;

        public HistoryInventarioRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }



        public void Update(HistoryInventario historyInventario)
        {
            var objDesdeDB = _db.HistoryInventario.FirstOrDefault(s => s.Id == historyInventario.Id);
            objDesdeDB.Cantidad = historyInventario.Cantidad;
            objDesdeDB.Tipo = historyInventario.Tipo;
            objDesdeDB.IdProducto = historyInventario.IdProducto;
            objDesdeDB.Comentario = historyInventario.Comentario;
            objDesdeDB.Fecha = historyInventario.Fecha;
            objDesdeDB.Estado = historyInventario.Estado;

            _db.SaveChanges();
        }
    }
}
