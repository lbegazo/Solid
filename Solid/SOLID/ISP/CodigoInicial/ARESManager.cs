using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.ISP.CodigoInicial
{
    public class ARESManager : IArchivoRecorder
    {
        public void GuardarArchivoPago(int idOrdenBancaria)
        {
            //Guarda el archivo en ARES
        }

        public void SetConexionString(string conexion)
        {
            //Metodo vacío, obligo a la clase a implementar un método que no utilizará
            throw new NotImplementedException();
        }
    }
}
