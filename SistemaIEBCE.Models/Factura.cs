using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIEBCE.Models
{
    public class Factura
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El Estudiante es obligatorio")]
        [Display(Name = "Estudiante")]
        public int IdAsigEstudiante { get; set; }

        [Required(ErrorMessage = "La refetencia a caja es obligatorio")]
        [Display(Name = "Caja")]
        public int IdCaja { get; set; }

        [Required(ErrorMessage = "La fecha es obligatoria")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Column("Fecha", TypeName = "Date")]
        [Display(Name = "Fecha")]
        public DateTime Fecha { get; set; }

        [Display(Name = "No. Factura")]
        public float NoFactura { get; set; }

        [ForeignKey("IdAsigEstudiante")]
        public AsigEstudiante AsigEstudiante { get; set; }

        [ForeignKey("IdCaja")]
        public Caja Caja { get; set; }
    }
}
