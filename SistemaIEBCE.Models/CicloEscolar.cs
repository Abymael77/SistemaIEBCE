using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIEBCE.Models
{
    public class CicloEscolar
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El Año es obligatorio")]
        [Display(Name = "Año")]
        public int Anio { get; set; }

        [Required(ErrorMessage = "El Grado es obligatorio")]
        [Display(Name = "Grado")]
        public int IdGrado { get; set; }
        
        [Required(ErrorMessage = "La Sección es un campo obligatorio")]
        [Display(Name = "sección")]
        public int IdSeccion { get; set; }

        public int Estado { get; set; }

        [ForeignKey("IdGrado")]
        public Grado Grado { get; set; }

        [ForeignKey("IdSeccion")]
        public Seccion Seccion { get; set; }

    }
}
