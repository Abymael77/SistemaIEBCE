using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIEBCE.Models
{
    public class Gasto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El Nombre del Gasto es obligatorio")]
        [StringLength(30, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 1)]
        [Display(Name = "Nombre de Gasto")]
        public string NomGasto { get; set; }

        [Display(Name = "Descripción")]
        public string DescGasto { get; set; }

        public int Estado { get; set; }
    }
}
