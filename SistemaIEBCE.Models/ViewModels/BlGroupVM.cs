using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIEBCE.Models.ViewModels
{
    public class BlGroupVM
    {
        public int Id { get; set; }

        public string NomBloque { get; set; }

        public int IdCicloEscolar { get; set; }
        
    }
}
