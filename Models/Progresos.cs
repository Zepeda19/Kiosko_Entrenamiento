using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kiosko.Models
{
    public class Progresos
    {
        [Key]
        public int Id { get; set; }
        public int Id_Usuario { get; set; }
        public int Id_Modulo { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public DateTime Fecha_Final { get; set; }
        public decimal Tiempo_Acumulado { get; set; }
        public string Submodulo_Actual { get; set; }
        public float Finalizado { get; set; }
    }
}
