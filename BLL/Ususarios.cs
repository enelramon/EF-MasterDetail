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
    }
}
