using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.LSP.CodigoInicial
{
    public class BaseDatosManager : ARESManager
    {
        string conexionString = string.Empty;

        public override void GuardarArchivoPago(int idOrdenBancaria)
        {
            //Guardar archivo en base de datos
            //FILESTREAM habilitado en SQL Server
        }

        public void SetConexionString(string conexion)
        {
            this.conexionString = conexion;
        }
    }
}
