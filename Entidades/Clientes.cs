using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }
        public string Nombres { get; set; }
        public virtual ICollection<Cotizaciones> Cotizaciones { get; set; }

        public Clientes()
        {
            this.Cotizaciones = new HashSet<Cotizaciones>();
        }
    }
}
