using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
  public  class TiposProductos
    {
        //Me vi en la necesidad de crear la BLL ya que no existia al momento de clonar el proyecto
        public static Entidades.TiposProductos Guardar(Entidades.TiposProductos nuevo)
        {
            Entidades.TiposProductos creado = null;
            using (var repositorio = new Repositorio<Entidades.TiposProductos>())
            {
                creado = repositorio.Guardar(nuevo);
            }

            return creado;

        }

    }
}
