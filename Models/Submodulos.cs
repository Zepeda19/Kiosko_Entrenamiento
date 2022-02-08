using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kiosko.Models
{
    public class Submodulos
    {
        [Key]
        public int intSubmodulosKey { get; set; }
        public Nullable<int> intModuloLink { get; set; }
        public string vchTitulo { get; set; }
        public Nullable<bool> bitAcceso_directo { get; set; }
        public Nullable<int> intNivel { get; set; }
        public string vchPadre { get; set; }
    }
}
