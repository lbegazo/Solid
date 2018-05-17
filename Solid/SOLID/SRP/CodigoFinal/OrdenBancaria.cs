using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.SRP.CodigoFinal
{
    public class OrdenBancaria
    {
        int idOrdenBancaria = 5;
        int idOrdenPago = 0;

        ARESManager archivo = new ARESManager();
        OrdenPago ordenPago = new OrdenPago();

        public void EjecutarProcesoPago()
        {            
            List<Object> lista = ordenPago.ObtenerOrdenesPago(idOrdenBancaria);

            foreach (var item in lista)
            {
                ordenPago.ActualizarOrdenPago(idOrdenPago);
            }

            archivo.GuardarArchivoPago(idOrdenBancaria);          
            
            this.ActualizarOrdenBancaria(idOrdenBancaria);
        }

        public void ActualizarOrdenBancaria(int idOrdenBancaria)
        {
            //Actualiza saldos y estado de la Orden Bancaria
        }
    }
}
