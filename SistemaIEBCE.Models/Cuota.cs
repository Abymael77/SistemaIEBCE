using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIEBCE.Models
{
    public class Cuota
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El Nombre de la Cuota es obligatorio")]
        [StringLength(30, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 1)]
        [Display(Name = "Nombre de Cuota")]
        public string NomCuota { get; set; }

        [Display(Name = "Descripción")]
        public string DescpCuota { get; set; }

        [Required(ErrorMessage = "El Monto de la Cuota es obligatorio")]
        [Display(Name = "Monto")]
        public float Monto { get; set; }

        [Required(ErrorMessage = "Debe especificar la cantidad de pagos")]
        [Display(Name = "Cantidad de pagos")]
        public int Cantidad { get; set; }

        public int Estado { get; set; }
    }
}
