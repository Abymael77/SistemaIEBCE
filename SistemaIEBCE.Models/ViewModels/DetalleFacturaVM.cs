using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIEBCE.Models
{
    public class DetalleFacturaVM
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El tipo de cuota es obligatorio")]
        [Display(Name = "Cuota")]
        public int IdCuota { get; set; }

        [Required(ErrorMessage = "El tipo de cuota es obligatorio")]
        [Display(Name = "Cuota")]
        public string NomCuota { get; set; }

        [Required(ErrorMessage = "La refetencia a una factura es obligatorio")]
        [Display(Name = "Factura")]
        public int IdFactura { get; set; }

        [Required(ErrorMessage = "El Monto de la Cuota es obligatorio")]
        [Display(Name = "Monto")]
        public float Monto { get; set; }

        [Display(Name = "Cantidad")]
        public int Cantidad { get; set; }

        [ForeignKey("IdCuota")]
        public Cuota Cuota { get; set; }

        [ForeignKey("IdFactura")]
        public  Factura Factura { get; set; }
    }
}
