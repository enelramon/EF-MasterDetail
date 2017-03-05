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
        
        public static List<Entidades.Clientes> GetListId(int id)
        {
            using (var repositorio = new Repositorio<Entidades.Clientes>())
            {
                return (repositorio.Lista(p => p.ClienteId == id));
            }
        }

        public static List<Entidades.Clientes>GetListNombre(string nombre)
        {
            using (var repositorio = new Repositorio<Entidades.Clientes>())
            {
                return (repositorio.Lista(p => p.Nombres == nombre));
            }
        }

        public static List<Entidades.Clientes> GetListDireccion(string direccion)
        {
            using (var repositorio = new Repositorio<Entidades.Clientes>())
            {
                return (repositorio.Lista(p => p.Direccion == direccion));
            }
        }

        public static List<Entidades.Clientes> GetListEmail(string email)
        {
            using (var repositorio = new Repositorio<Entidades.Clientes>())
            {
                return (repositorio.Lista(p => p.Email == email));
            }
        }

        public static List<Entidades.Clientes> GetListTelefono(int telefono)
        {
            using (var repositorio = new Repositorio<Entidades.Clientes>())
            {
                return (repositorio.Lista(p => p.Telefono == Convert.ToString(telefono)));
            }
        }

        public static List<Entidades.Clientes> GetListCelular(int celular)
        {
            using (var repositorio = new Repositorio<Entidades.Clientes>())
            {
                return (repositorio.Lista(p => p.Celular == Convert.ToString(celular)));
            }
        }

        public static List<Entidades.Clientes> GetListLimiteCredito(int limite)
        {
            using (var repositorio = new Repositorio<Entidades.Clientes>())
            {
                return (repositorio.Lista(p => p.LimiteCredito == limite));
            }
        }

    }
}
