using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;


namespace CapaDatos
{
    class DatosConexion
    {
        public OleDbConnection conexion;

        public string cadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = C:\Users\Ibañez\Desktop\WindFormProd\Productos.accdb";

        public DatosConexion()
        {
            conexion = new OleDbConnection(cadenaConexion);
        }

        public void AbrirConexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Broken || conexion.State == ConnectionState.Closed)
                    conexion.Open();

            }
            catch (Exception fail)
            {
                throw new Exception("Se encontro un error al abrir la conexión", fail);

            }
        }
        public void Cerrarconexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                        conexion.Close();
            }
            catch (Exception fail)
            {
                throw new Exception("Se encontro un error al cerrar la conexión", fail);
            }
        }
    }
}