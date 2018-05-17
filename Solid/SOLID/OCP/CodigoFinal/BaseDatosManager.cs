using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OCP.CodigoFinal
{
    public class BaseDatosManager : ARESManager
    {
        public override void GuardarArchivoPago(int idOrdenBancaria)
        {
            //Guardar archivo en base de datos
            Console.WriteLine("Guardar archivo en base de datos");
        }
    }
}
