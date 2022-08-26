using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIEBCE.Models
{
    public class Curso
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del curso es obligatorio")]
        [StringLength(50, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 2)]
        [Display(Name = "Nombre Curso")]
        public string NomCurso { get; set; }

        [Display(Name = "Descripción del curso")]
        [StringLength(255, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 10)]
        public string Descripcion { get; set; }

        public int Estado { get; set; }
    }
}
