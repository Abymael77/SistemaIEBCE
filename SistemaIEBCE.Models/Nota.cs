using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIEBCE.Models
{
    public class Nota
    {
        [Key]
        public Nullable<int> Id { get; set; }

        [Required(ErrorMessage = "El Estudiante es obligatorio")]
        [Display(Name = "Estudiante")]
        public int IdAsigEstudinate { get; set; }

        [Required(ErrorMessage = "El Bloque es un campo obligatorio")]
        [Display(Name = "Bloque")]
        public int IdBloqueAsigCurso { get; set; }

        [Required(ErrorMessage = "El punteo es un campo obligatorio")]
        [Display(Name = "Punteo")]
        public int Punteo { get; set; }

        [ForeignKey("IdAsigEstudinate")]
        public AsigEstudiante asigEstudiante { get; set; }

        [ForeignKey("IdBloqueAsigCurso")]
        public BloqueAsigCurso BloqueAsigCurso { get; set; }

    }
}
