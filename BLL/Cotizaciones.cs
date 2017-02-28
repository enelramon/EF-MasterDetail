using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Cotizaciones
    {
        public static Entidades.Cotizaciones Guardar(Entidades.Cotizaciones cotizacion)
        {
            Entidades.Cotizaciones creado = null;
            using (var repositorio = new Repositorio<Entidades.Cotizaciones>())
            {
                //todo: validar que el nombre de producto no exista

                creado = repositorio.Guardar(cotizacion);
            }

            return creado;
        }
    }
}
