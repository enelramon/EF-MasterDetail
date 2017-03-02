using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
  public  class TiposProductos
    {
        public static bool Guardar(Entidades.TiposProductos nuevo)
        {
            bool retorno = false;
            using (var db = new Repositorio<Entidades.TiposProductos>())
            {
                retorno = db.Guardar(nuevo) != null;
            }
            return retorno;

        }


        public static bool Eliminar(Entidades.TiposProductos ID)
        {
            bool resultado = false;
            using (var db = new Repositorio<Entidades.TiposProductos>())
            {
                resultado = db.Eliminar(ID);

            }
            return resultado;
        }
    }
}
