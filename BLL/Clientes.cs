using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    }
}
