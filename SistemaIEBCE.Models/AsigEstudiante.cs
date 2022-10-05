using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIEBCE.Models
{
    public class AsigEstudiante
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El Estudiante es obligatorio")]
        [Display(Name = "Estudiante")]
        public int IdEstudiante { get; set; }

        [Required(ErrorMessage = "El Ciclo Escolar es un campo obligatorio")]
        [Display(Name = "Ciclo Escolar")]
        public int IdCicloEscolar { get; set; }

        public int Estado { get; set; }

        [ForeignKey("IdEstudiante")]
        public Estudiante Estudiante { get; set; }

        [ForeignKey("IdCicloEscolar")]
        public CicloEscolar CicloEscolar { get; set; }

    }
}
