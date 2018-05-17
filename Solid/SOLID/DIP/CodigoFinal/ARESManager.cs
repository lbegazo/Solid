using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.DIP.CodigoFinal
{
    public class ARESManager : IArchivoRecorder
    {
        public void GuardarArchivoPago(int idOrdenBancaria)
        {
            Console.WriteLine("Guardó archivo en ARES");
        }
    }
}
