using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.LSP.CodigoInicial
{
    public class OrdenBancaria
    {
        OrdenPago ordenPago = new OrdenPago();
        int idOrdenBancaria = 5;

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
            if (this._archivo.GetType() == typeof(BaseDatosManager))
            {
                (this._archivo as BaseDatosManager).SetConexionString("DataSource=./sqlexpress...");
            }

            int idOrdenPago = 0;
            List<Object> lista = ordenPago.ObtenerOrdenesPago(idOrdenBancaria);

            foreach (var item in lista)
            {
                ordenPago.ActualizarOrdenPago(idOrdenPago);
            }
            Console.WriteLine("Actualiza saldos y estado de toda las OPs");

            _archivo.GuardarArchivoPago(idOrdenBancaria); 
            
            this.ActualizarOrdenBancaria(idOrdenBancaria);
        }

        public void ActualizarOrdenBancaria(int idOrdenBancaria)
        {
            //Actualiza saldos y estado de la Orden Bancaria
            Console.WriteLine("Actualiza saldos y estado de la Orden Bancaria");
        }
    }
}
