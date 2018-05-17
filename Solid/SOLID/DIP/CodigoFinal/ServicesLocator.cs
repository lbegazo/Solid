using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.DIP.CodigoFinal
{
    public class ServicesLocator
    {
        internal static T Find<T>() where T : class
        {
            if (typeof(T).GetInterfaces()[0] == typeof(IArchivoRecorder))            
                return new ARESManager() as T;

            if (typeof(T).GetInterfaces()[0] == typeof(IBaseDatosManager))
                return new ARESManager() as T;

            if (typeof(T).GetInterfaces()[0] == typeof(IOrdenPago))
                return new OrdenPago() as T;

            throw new TypeLoadException($"can not find type {typeof(T).Name}");
        }
    }
}
