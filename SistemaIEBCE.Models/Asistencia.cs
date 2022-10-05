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
    public class Asistencia
    {
        [Key]
        public Nullable<int> Id { get; set; }
        //public Nullable<int> Id { get; set; }

        [Required(ErrorMessage = "La fecha es obligatoria")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Column("Fecha", TypeName = "Date")]
        [Display(Name = "Fecha")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "El Tipo es un campo obligatorio")]
        [Display(Name = "Tipo")]
        public string Tipo { get; set; }

        [Display(Name = "Comentario")]
        public string Comentario { get; set; }

        [Required(ErrorMessage = "El Estudiante es obligatorio")]
        [Display(Name = "Estudiante")]
        public int IdAsigEstudinate { get; set; }

        [Required(ErrorMessage = "El Bloque es un campo obligatorio")]
        [Display(Name = "Bloque")]
        public int IdBloqueAsigCurso { get; set; }

        [ForeignKey("IdAsigEstudinate")]
        public AsigEstudiante asigEstudiante { get; set; }
        
        [ForeignKey("IdBloqueAsigCurso")]
        public BloqueAsigCurso BloqueAsigCurso { get; set; }

    }
}
