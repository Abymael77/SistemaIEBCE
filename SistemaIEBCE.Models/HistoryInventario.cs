using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIEBCE.Models
{
    public class HistoryInventario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El Producto es obligatorio")]
        [Display(Name = "Producto")]
        public int IdProducto { get; set; }

        [Display(Name = "Cantidad")]
        public int Cantidad { get; set; }

        [Display(Name = "Tipo")]
        public int Tipo { get; set; }

        [Display(Name = "Comentario")]
        [StringLength(255, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 5)]
        public string Comentario { get; set; }

        public int Estado { get; set; }


        [Required(ErrorMessage = "La fecha es obligatoria")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Column("Fecha", TypeName = "Date")]
        [Display(Name = "Fecha")]
        public DateTime Fecha { get; set; }

        [ForeignKey("IdProducto")]
        public Producto Producto { get; set; }

    }
}
