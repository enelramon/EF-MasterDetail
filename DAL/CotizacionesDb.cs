using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace DAL
{
    public class CotizacionesDb : DbContext
    {
        public CotizacionesDb() : base("ConStr")
        {

        }

        public DbSet<Entidades.Productos> Productos { get; set; }
        public DbSet<Entidades.Clientes> Clientes { get; set; }
        public DbSet<Entidades.Cotizaciones> Cotizaciones { get; set; }

    }
}
