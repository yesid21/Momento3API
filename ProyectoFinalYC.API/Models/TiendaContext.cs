using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProyectoFinalYC.API.Models
{
    public class TiendaContext : DbContext
    {
        public TiendaContext() : base("ProyectoFinalYCConnection")
        {

        }
        public DbSet<Producto> Productos { get; set; }
    }
}