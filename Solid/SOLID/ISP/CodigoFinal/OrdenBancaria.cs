using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.ISP.CodigoFinal
{
    public class OrdenBancaria
    {
        OrdenPago ordenPago = new OrdenPago();
        int idOrdenPago = 0;
        int idOrdenBancaria = 5;

        private IArchivoRecorder _archivoManager;

        public IArchivoRecorder ArchivoManager
        {
            get
            {
                if (this._archivoManager == null)
                    this._archivoManager = new ARESManager();

                return _archivoManager;
            }
            set { this._archivoManager = value; }
        }        

        public void EjecutarProcesoPago()
        {   
            List<Object> lista = ordenPago.ObtenerOrdenesPago(idOrdenBancaria);

            foreach (var item in lista)
            {
                ordenPago.ActualizarOrdenPago(idOrdenPago);
            }
            Console.WriteLine("Actualiza saldos y estado de toda las OPs");

            ArchivoManager.GuardarArchivoPago(idOrdenBancaria);    
            
            this.ActualizarOrdenBancaria(idOrdenBancaria);
        }

        public void ActualizarOrdenBancaria(int idOrdenBancaria)
        {
            //Actualiza saldos y estado de la Orden Bancaria
            Console.WriteLine("Actualiza saldos y estado de la Orden Bancaria");
        }
    }
}
