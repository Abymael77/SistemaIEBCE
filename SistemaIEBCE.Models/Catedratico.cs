using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIEBCE.Models
{
    public class Catedratico
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Los Nombres del Catedrático son obligatorios")]
        [StringLength(40, ErrorMessage = "Los {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 5)]
        [Display(Name = "Nombres del Catedrático")]
        public string NomCatedratico { get; set; }

        [Required(ErrorMessage = "Los Apellidos del Catedrático son obligatorios")]
        [StringLength(30, ErrorMessage = "Los {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Apellidos del Catedrático")]
        public string ApellCatedratico { get; set; }

        [Required(ErrorMessage = "El Sexo del Catedrático es obligatorio")]
        [StringLength(1, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 1)]
        [Display(Name = "Sexo")]
        public string Sexo { get; set; }

        [Required(ErrorMessage = "El Número de Telefono del Catedrático es obligatorio")]
        [Display(Name = "Número de Teléfono")]
        public int Tel { get; set; }

        [Required(ErrorMessage = "La Profesion del Catedrático es obligatorio")]
        [StringLength(40, ErrorMessage = "La {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 5)]
        [Display(Name = "Profesión del Catedrático")]
        public string Profesion { get; set; }

        public int Estado { get; set; }
    }
}
