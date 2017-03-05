using DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
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


        public static bool Mofidicar(Entidades.TiposProductos existente)
        {
            bool eliminado = false;
            using (var repositorio = new Repositorio<Entidades.TiposProductos>())
            {
                eliminado = repositorio.Modificar(existente);
            }

            return eliminado;

        }

        public static bool Eliminar(Entidades.TiposProductos existente)
        {
            bool eliminado = false;
            using (var repositorio = new Repositorio<Entidades.TiposProductos>())
            {
                eliminado = repositorio.Eliminar(existente);
            }

            return eliminado;

        }

        public static Entidades.TiposProductos  Buscar(Expression<Func<Entidades.TiposProductos, bool>> tipo)
        {
            Entidades.TiposProductos Result = null;
            using (var repoitorio = new Repositorio<Entidades.TiposProductos>())

            {
                Result = repoitorio.Buscar(tipo);
            }
                
            return Result;
        }

    }
}
