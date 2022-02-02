using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kiosko.Models
{
    public class Notificaciones
    {
        [Key]
        public int Id { get; set; }
        public int Id_Usuario { get; set; }
        public string Notificacion { get; set; }
        public bool Visto { get; set; }

    }
}
