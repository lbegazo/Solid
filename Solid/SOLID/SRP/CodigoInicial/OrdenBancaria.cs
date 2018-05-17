using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.SRP.CodigoInicial
{
    public class OrdenBancaria
    {
        int idOrdenBancaria = 5;
        int idOrdenPago = 0;

        public void EjecutarProcesoPago()
        {            
            List<Object> lista = ObtenerOrdenesPago(idOrdenBancaria);

            foreach (var item in lista)
            {
                ActualizarOrdenPago(idOrdenPago);
            }
            Console.WriteLine("Actualiza saldos y estado de toda las OPs");

            GuardarArchivoPago(idOrdenBancaria);   
            
            ActualizarOrdenBancaria(idOrdenBancaria);
        }

        private List<Object> ObtenerOrdenesPago(int idOrdenBancaria)
        {
            return new List<Object>();
        }

        private void ActualizarOrdenPago(int idOrdenPago)
        {
            //Actualiza saldos y estado de la Orden de Pago
        }

        private void GuardarArchivoPago(int idOrdenBancaria)
        {
            //Guardar archivo en ARES
            Console.WriteLine("Guardar archivo en ARES");
        }

        private void ActualizarOrdenBancaria(int idOrdenBancaria)
        {
            //Actualiza saldos y estado de la Orden Bancaria
            Console.WriteLine("Actualiza saldos y estado de la Orden Bancaria");
        }
    }    
}
