using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OCP.CodigoFinal
{
    public class OrdenBancaria
    {
        OrdenPago ordenPago = new OrdenPago();
        int idOrdenBancaria = 5;
        int idOrdenPago = 0;        

        private ARESManager _archivo;

        public ARESManager Archivo
        {
            get
            {
                if (this._archivo == null)
                    this._archivo = new ARESManager();

                return _archivo;
            }

            set { this._archivo = value; }
        }        

        public void EjecutarProcesoPago()
        {            
            List<Object> lista = ordenPago.ObtenerOrdenesPago(idOrdenBancaria);

            foreach (var item in lista)
            {
                ordenPago.ActualizarOrdenPago(idOrdenPago);
            }
            Console.WriteLine("Actualiza saldos y estado de toda las OPs");

            _archivo.GuardarArchivoPago(idOrdenBancaria);            

            this.ActualizarOrdenBancaria(idOrdenBancaria);
        }

        private void ActualizarOrdenBancaria(int idOrdenBancaria)
        {
            //Actualiza saldos y estado de la Orden Bancaria
            Console.WriteLine("Actualiza saldos y estado de la Orden Bancaria");
        }
    }
}
