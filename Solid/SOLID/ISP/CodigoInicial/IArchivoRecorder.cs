using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.ISP.CodigoInicial
{
    public interface IArchivoRecorder
    {
        void GuardarArchivoPago(int idOrdenBancaria);

        void SetConexionString(string conexion);
    }
}
