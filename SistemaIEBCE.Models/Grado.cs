using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIEBCE.Models
{
    public class Grado
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El Nombre del Grado obligatorio")]
        [StringLength(30, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 2)]
        [Display(Name = "Grado")]
        public string NomGrado { get; set; }

        public int Estado { get; set; }
    }
}
