using System.Data.Entity;

namespace DAL
{
    public class CotizacionesDb : DbContext
    {
        public CotizacionesDb() : base("ConStr")
        {

        }
      
        public DbSet<Entidades.Productos> Productos { get; set; }
        public DbSet<Entidades.Usuarios> Usuarios { get; set; }
        public DbSet<Entidades.Clientes> Clientes { get; set; }
        public DbSet<Entidades.Cotizaciones> Cotizaciones { get; set; }
        public DbSet<Entidades.TiposProductos> TipoProductos { get; set; }
    }
}
