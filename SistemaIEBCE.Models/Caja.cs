using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIEBCE.Models
{
    public class Caja
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "La fecha es obligatoria")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [Column("Inicio", TypeName = "Date")]
        [Display(Name = "Fecha Inicio")]
        public DateTime Inicio { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [Column("Fin", TypeName = "Date")]
        [Display(Name = "Fecha Fin")]
        public DateTime? Fin { get; set; }

        [Required(ErrorMessage = "El Monto de la Cuota es obligatorio")]
        [Display(Name = "Monto Inicial")]
        public float MontoInicial { get; set; }

        public int Estado { get; set; }
    }
}
