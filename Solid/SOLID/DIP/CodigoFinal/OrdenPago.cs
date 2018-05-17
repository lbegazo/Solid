using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.DIP.CodigoFinal
{
    public class OrdenPago : IOrdenPago
    {
        public List<Object> ObtenerOrdenesPago(int idOrdenBancaria)
        {
            return new List<Object>();
        }

        public void ActualizarOrdenPago(int idOrdenPago)
        {
            throw new NotImplementedException();
        }
    }
}
