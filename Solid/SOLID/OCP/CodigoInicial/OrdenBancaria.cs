using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OCP.CodigoInicial
{
    public class OrdenBancaria
    {
        int idOrdenBancaria = 0;
        
        ARESManager archivo = new ARESManager();
        OrdenPago ordenPago = new OrdenPago();

        public void EjecutarProcesoPago()
        {
            int idOrdenPago = 0;
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
            throw new NotImplementedException();
        }
    }
}
