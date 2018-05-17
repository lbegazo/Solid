using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.ISP.CodigoFinal
{
    public class ARESManager : IArchivoRecorder
    {
        public void GuardarArchivoPago(int idOrdenBancaria)
        {
            //Guarda el archivo en ARES
            Console.WriteLine("Guardar archivo en ARES");
        }
    }
}
