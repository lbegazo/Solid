using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OCP.CodigoFinal
{
    public class ARESManager
    {
        public virtual void GuardarArchivoPago(int idOrdenBancaria)
        {
            //Guardar archivo en ARES
            Console.WriteLine("Guardar archivo en ARES");
        }
    }
}
