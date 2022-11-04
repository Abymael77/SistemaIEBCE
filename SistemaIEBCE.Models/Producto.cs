using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIEBCE.Models
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El Nombre de Producto obligatorio")]
        [StringLength(150, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 1)]
        [Display(Name = "Nombre de Producto")]
        public string NomProducto { get; set; }

        [StringLength(30, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 1)]
        [Display(Name = "Nombre de Producto")]
        public string Codigo { get; set; }

        [Display(Name = "Descripción")]
        [StringLength(255, ErrorMessage = "La {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 10)]
        public string Descripcion { get; set; }

        public int Estado { get; set; }
    }
}
