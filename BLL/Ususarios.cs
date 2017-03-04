using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class Ususarios
    {
        public static Entidades.Usuarios Guardar(Entidades.Usuarios usuarios)
        {
            Entidades.Usuarios hecho = null;
            using (var repositorio = new Repositorio<Entidades.Usuarios>())
            {
                hecho = repositorio.Guardar(usuarios);
            }
            return hecho;
        }

        public static List<Entidades.Usuarios> GetList()
        {
            using (var repositorio = new Repositorio<Entidades.Usuarios>())
            {
                return (repositorio.ListaTodo());
            }
        }

        public static List<Entidades.Usuarios> GetListNombre(String nombre)
        {
            using (var repositorio = new Repositorio<Entidades.Usuarios>())
            {
                return (repositorio.Lista(U => U.Nombre == nombre));
            }
        }

        public static List<Entidades.Usuarios> GetListId(int usuarioId)
        {
            using (var repositorio = new Repositorio<Entidades.Usuarios>())
            {
                return (repositorio.Lista(U => U.UsuarioId == usuarioId));
            }
        }
    }
}
