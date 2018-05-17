using System;
using Microsoft.Extensions.DependencyInjection;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proceso iniciado!");

            //Codigo Inicial
            //var ordenBancaria = new SRP.CodigoInicial.OrdenBancaria();
            //ordenBancaria.EjecutarProcesoPago();

            //OCP
            //var ordenBancariaOCP = new OCP.CodigoFinal.OrdenBancaria();
            //ordenBancariaOCP.Archivo = new OCP.CodigoFinal.BaseDatosManager();            
            //ordenBancariaOCP.EjecutarProcesoPago();

            //ALL
            var ordenBancariaSOLID = new DIP.CodigoFinal.OrdenBancaria();
            var serviceProvider = new ServiceCollection()
                .AddSingleton<DIP.CodigoFinal.IArchivoRecorder, DIP.CodigoFinal.BaseDatosManager>()
                .AddSingleton<DIP.CodigoFinal.IOrdenPago, DIP.CodigoFinal.OrdenPago>()
                .BuildServiceProvider();

            var archivo = serviceProvider.GetService<DIP.CodigoFinal.IArchivoRecorder>();
            var ordenPago = serviceProvider.GetService<DIP.CodigoFinal.IOrdenPago>();
            ordenBancariaSOLID.EjecutarProcesoPago(archivo, ordenPago);

            Console.WriteLine("Proceso ejecutado!");
            Console.ReadKey();
        }
    }
}
