using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kiosko.Models
{
    public class Componentes
    {
        [Key]
        public int Id { get; set; }
        public int Modulo { get; set; }
        public string Tipo_Componente { get; set; }
        public string Url { get; set; }
        public string Descripcion { get; set; }
        public bool Background_Color { get; set; }
        public int Orden { get; set; }
        public bool Agregar_Fondo { get; set; }
        public string Titulo { get; set; }
        public string Subtitulo { get; set; }
    }
}
