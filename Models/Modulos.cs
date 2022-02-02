using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kiosko.Models
{
    public class Modulos
    {
        [Key]
        public int intModuloKey { get; set; }
        public string vchTitulo { get; set; }
        public Nullable<bool> bitAccesoDirecto { get; set; }
        public Nullable<int> intOrden { get; set; }
    }
}
