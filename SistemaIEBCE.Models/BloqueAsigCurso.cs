using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIEBCE.Models
{
    public class BloqueAsigCurso
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El bloque es un campo obligatorio")]
        [Display(Name = "Bloque")]
        public int IdBloque { get; set; }

        [Required(ErrorMessage = "La asignacion de curso es obligatorio")]
        [Display(Name = "Curso")]
        public int IdAsigCurso { get; set; }

        public int Estado { get; set; }

        [ForeignKey("IdBloque")]
        public Bloque Bloque { get; set; }

        [ForeignKey("IdAsigCurso")]
        public AsigCurso AsigCurso { get; set; }
    }
}
