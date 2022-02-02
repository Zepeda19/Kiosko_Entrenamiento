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
        public int Id { get; set; }
        public int Id_Modulo { get; set; }
        public string Titulo { get; set; }
        public int Nivel { get; set; }
        public string Padre { get; set; }
    }
}
