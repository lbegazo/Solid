using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.DIP.CodigoFinal
{
    public interface IOrdenPago
    {
        List<Object> ObtenerOrdenesPago(int idOrdenBancaria);

        void ActualizarOrdenPago(int idOrdenPago);
    }
}
