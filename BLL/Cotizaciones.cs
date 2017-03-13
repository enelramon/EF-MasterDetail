using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

        public static bool Mofidicar(Entidades.Cotizaciones cotizacion)
        {
            bool eliminado = false;
            using (var repositorio = new Repositorio<Entidades.Cotizaciones>())
            {
                eliminado = repositorio.Modificar(cotizacion);
            }

            return eliminado;

        }

        public static bool Eliminar(Entidades.Cotizaciones cotizacion)
        {
            bool eliminado = false;

            using (var repositorio = new Repositorio<Entidades.Cotizaciones>())
            {
                eliminado = repositorio.Eliminar(cotizacion);
            }

            return eliminado;
        }

        public static Entidades.Cotizaciones Buscar(Expression<Func<Entidades.Cotizaciones, bool>> tipo)
        {
            Entidades.Cotizaciones Result = null;

            using (var repositorio = new Repositorio<Entidades.Cotizaciones>())
            {
                Result = repositorio.Buscar(tipo);

                if (Result != null)
                    Result.Detalle.Count();//para oblibar el lazyloading a cargar los datos
            }

            return Result;
        }
    }
}
