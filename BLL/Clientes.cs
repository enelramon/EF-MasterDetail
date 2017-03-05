using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace BLL
{
    public class Clientes
    {
        public static Entidades.Clientes Guardar(Entidades.Clientes cliente)
        {
            Entidades.Clientes creado = null;
            using (var repositorio = new Repositorio<Entidades.Clientes>())
            {
                //todo: validar que la cedula del cliente no exista

                creado = repositorio.Guardar(cliente);
            }

            return creado;
        }

        
        public static List<Entidades.Clientes> Lista(Expression<Func<Entidades.Clientes, bool>> CriterioBusqueda)
        {
            List<Entidades.Clientes> buscado = null;
            using (var repositorio = new Repositorio<Entidades.Clientes>())
            {
                try
                {
                    buscado = repositorio.Lista(CriterioBusqueda).ToList(); 
                }
                catch
                {

                }
                return buscado;
            }
        }

    }
}
