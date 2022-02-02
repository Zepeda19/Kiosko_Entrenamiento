using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kiosko.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        public int Id_empleado { get; set; }
        public string tipo_Usuario { get; set; }
        public int Clave { get; set; }
        public string Rol { get; set; }
    }
}
