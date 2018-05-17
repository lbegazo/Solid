using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.ISP.CodigoInicial
{
    public class BaseDatosManager : IArchivoRecorder
    {
        string conexionString = string.Empty;

        public void GuardarArchivoPago(int idOrdenBancaria)
        {
            //Guarda el archivo en la base de datos
        }

        public void SetConexionString(string conexion)
        {
            //Establece la cadena de conexión a la base de datos
            this.conexionString = conexion;
        }
    }
}
