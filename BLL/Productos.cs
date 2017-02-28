using DAL; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Productos
    {
       public  static Entidades.Productos Guardar(Entidades.Productos producto)
        {
            Entidades.Productos creado = null;
            using (var repositorio = new Repositorio<Entidades.Productos >())
            {
                //todo: validar que el nombre de producto no exista

               creado= repositorio.Guardar(producto) ;
            }

            return creado;
        }

    }
}
