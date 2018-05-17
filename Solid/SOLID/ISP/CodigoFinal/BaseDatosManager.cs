using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.ISP.CodigoFinal
{
    public class BaseDatosManager : IArchivoRecorder, IBaseDatosManager
    {
        string conexionString = string.Empty;

        public void GuardarArchivoPago(int idOrdenBancaria)
        {
            Console.WriteLine("Guardar archivo en base de datos");
        }

        public void SetConnectionString(string conexion)
        {
            this.conexionString = conexion;
        }
    }
}
