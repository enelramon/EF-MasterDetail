using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
   public class TiposProductos
    {
        [Key]
        public int TipoId { get; set; }
        public string Tipo { get; set; }
        public bool esActivo { get; set; }

    }
}
