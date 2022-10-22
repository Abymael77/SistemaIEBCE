using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIEBCE.Models
{
    public class DetalleGasto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El tipo de gasto es obligatorio")]
        [Display(Name = "Gasto")]
        public int IdGasto { get; set; }

        [Required(ErrorMessage = "La refetencia a caja es obligatorio")]
        [Display(Name = "Caja")]
        public int IdCaja { get; set; }

        [Required(ErrorMessage = "El Monto de la Cuota es obligatorio")]
        [Display(Name = "Monto")]
        public float Monto { get; set; }

        [Required(ErrorMessage = "La fecha es obligatoria")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Column("Fecha", TypeName = "Date")]
        [Display(Name = "Fecha")]
        public DateTime Fecha { get; set; }

        [Display(Name = "No. Factura")]
        public int NoFactura { get; set; }

        [ForeignKey("IdGasto")]
        public Gasto Gasto { get; set; }

        [ForeignKey("IdCaja")]
        public Caja Caja { get; set; }
    }
}
