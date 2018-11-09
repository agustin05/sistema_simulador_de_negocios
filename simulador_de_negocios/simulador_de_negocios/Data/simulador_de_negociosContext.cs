using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using simulador_de_negocios.Models;

namespace simulador_de_negocios.Models
{
    public class simulador_de_negociosContext : DbContext
    {
        public simulador_de_negociosContext (DbContextOptions<simulador_de_negociosContext> options)
            : base(options)
        {
        }

        public DbSet<simulador_de_negocios.Models.Mano_Obra_Operativa> Mano_Obra_Operativa { get; set; }

        public DbSet<simulador_de_negocios.Models.Producto_servicios> Producto_servicios { get; set; }
    }
}
