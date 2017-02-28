﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; } 

        public virtual ICollection<CotizacionesDetalle> CotizacionesDetalle { get; set; }

        public Productos()
        {
            this.CotizacionesDetalle = new HashSet<CotizacionesDetalle>();
        }

        public override string ToString()
        {
            return string.Format("ProductoId: {0}, Descripción: {1}", this.ProductoId, this.Descripcion);
        }

    }
}
