using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.DIP.CodigoFinal
{
    public class OrdenBancaria
    {
        int idOrdenBancaria = 5;
        int idOrdenPago = 0;
        
        public void EjecutarProcesoPago(IArchivoRecorder _archivoManager, IOrdenPago _ordenPago)
        {
            List<Object> lista = _ordenPago.ObtenerOrdenesPago(idOrdenBancaria);

            foreach (var item in lista)
            {
                _ordenPago.ActualizarOrdenPago(idOrdenPago);
            }
            Console.WriteLine("Actualizó saldos y estado de toda las OPs");

            _archivoManager.GuardarArchivoPago(idOrdenBancaria);

            this.ActualizarOrdenBancaria(idOrdenBancaria);
        }

        private void ActualizarOrdenBancaria(int idOrdenBancaria)
        {
            //Actualiza saldos y estado de la Orden Bancaria
            Console.WriteLine("Actualizó saldos y estado de la Orden Bancaria");
        }
    }
}
