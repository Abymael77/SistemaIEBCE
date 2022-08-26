using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIEBCE.Models
{
    public class Estudiante
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Los Nombres del Estudiante son obligatorios")]
        [StringLength(40, ErrorMessage = "Los {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 5)]
        [Display(Name = "Nombres del Estudiante")]
        public string NomEstudiante { get; set; }

        [Required(ErrorMessage = "Los Apellidos del Estudiante son obligatorios")]
        [StringLength(30, ErrorMessage = "Los {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Apellidos del Estudiante")]
        public string ApellEstudiante { get; set; }

        [Required(ErrorMessage = "El Sexo del Estudiante es obligatorio")]
        [StringLength(1, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 1)]
        [Display(Name = "Sexo")]
        public string Sexo { get; set; }

        [Required(ErrorMessage = "El Número de Carnet del Estudiante es obligatorio")]
        [Display(Name = "Número de Carnet")]
        public int Carnet { get; set; }

        [Required(ErrorMessage = "El Número de Telefono del Estudiante es obligatorio")]
        [Display(Name = "Tel. Estudiante")]
        public int TelEstudiante { get; set; }

        [Required(ErrorMessage = "Los Nombres y Apellidos del Encargado son obligatorios")]
        [StringLength(70, ErrorMessage = "Los {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 10)]
        [Display(Name = "Nombres del Encargado")]
        public string Encargado { get; set; }

        [Required(ErrorMessage = "El Número de Telefono del Encargado es obligatorio")]
        [Display(Name = "Tel. Encargado")]
        public int TelEncargado { get; set; }

        [Required(ErrorMessage = "La Direccion es obligatoria")]
        [StringLength(100, ErrorMessage = "Los {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 10)]
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }

        public int Estado { get; set; }
    }
}
