using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.ISP.CodigoInicial
{
    public class OrdenBancaria
    {
        OrdenPago ordenPago = new OrdenPago();
        int idOrdenBancaria = 5;
        private IArchivoRecorder _archivoRecorder;

        public IArchivoRecorder ArchivoRecorder
        {
            get
            {
                if (this._archivoRecorder == null)
                    this._archivoRecorder = new ARESManager();

                return _archivoRecorder;
            }
            set { this._archivoRecorder = value; }
        }        

        public void EjecutarProcesoPago()
        {
            int idOrdenPago = 0;
            List<Object> lista = ordenPago.ObtenerOrdenesPago(idOrdenBancaria);

            foreach (var item in lista)
            {
                ordenPago.ActualizarOrdenPago(idOrdenPago);
            }

            _archivoRecorder.GuardarArchivoPago(idOrdenBancaria);    
            
            this.ActualizarOrdenBancaria(idOrdenBancaria);
        }

        public void ActualizarOrdenBancaria(int idOrdenBancaria)
        {
            //Actualiza saldos y estado de la Orden Bancaria
        }
    }
}
