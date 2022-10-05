using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIEBCE.Models
{
    public class AsigCurso
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El Catedratico es obligatorio")]
        [Display(Name = "Catedrático")]
        public int IdCatedratico { get; set; }

        [Required(ErrorMessage = "El Curso es un campo obligatorio")]
        [Display(Name = "Curso")]
        public int IdCurso { get; set; }

        [Required(ErrorMessage = "El Ciclo Escolar es un campo obligatorio")]
        [Display(Name = "Ciclo Escolar")]
        public int IdCicloEscolar { get; set; }

        public int Estado { get; set; }

        [ForeignKey("IdCatedratico")]
        public Catedratico Catedratico { get; set; }

        [ForeignKey("IdCurso")]
        public Curso Curso { get; set; }

        [ForeignKey("IdCicloEscolar")]
        public CicloEscolar CicloEscolar { get; set; }
    }
}
