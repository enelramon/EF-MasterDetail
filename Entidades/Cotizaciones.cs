using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
   public class Cotizaciones
    {
        [Key]
        public int CotizacionId { get; set; }
        public DateTime Fecha { get; set; }
        public int ClienteId { get; set; }
        public decimal Monto { get; set; }

        public virtual Clientes Cliente { get; set; }
        public virtual ICollection<CotizacionesDetalle> Detalle { get; set; }

        public Cotizaciones()
        {
            this.Detalle = new HashSet<CotizacionesDetalle>();
        }

        public void AgregarDetalle(int productoId, decimal cantidad, decimal precio)
        {
            this.Detalle.Add(new CotizacionesDetalle(productoId, cantidad, precio));
        }
    }
}
