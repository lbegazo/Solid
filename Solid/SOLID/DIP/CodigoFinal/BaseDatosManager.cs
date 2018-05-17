using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using System.Text;

namespace SOLID.DIP.CodigoFinal
{
    public class BaseDatosManager : IArchivoRecorder, IBaseDatosManager
    {
        string conexionString = string.Empty;

        public IConfiguration Configuration { get; }

        public BaseDatosManager()
        {
            var conexion = Configuration.GetConnectionString("Default");
            this.SetConnectionString(conexion);
        }

        public BaseDatosManager(string conexion)
        {            
            this.SetConnectionString(conexion);
        }

        public void SetConnectionString(string conexion)
        {
            this.conexionString = conexion;
        }

        public void GuardarArchivoPago(int idOrdenBancaria)
        {
            Console.WriteLine("Guardó archivo en BASE DE DATOS");
        }
    }
}
