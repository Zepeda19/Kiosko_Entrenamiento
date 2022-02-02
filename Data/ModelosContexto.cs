using Kiosko.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kiosko.Data
{
    public class ModelosContexto : DbContext
    {
        public ModelosContexto(DbContextOptions<ModelosContexto> options) : base(options)
        {

        }

        public DbSet<Componentes> intComponentes { get; set; }
        public DbSet<Modulos> Modulos { get; set; }
        public DbSet<Notificaciones> intNotificaciones { get; set; }    
        public DbSet<Progresos> intProgresos { get; set; }
        public DbSet<Submodulos> intSubmodulos { get; set; }
        public DbSet<Usuario> intusuario { get; set; }

    }
}
