using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using Entidades;

namespace CapaDatos
{
    public class AdministracionProductos : DatosConexion
    {
     
        public int abmProducto(string accion, Producto objetoProducto) 
        {
            int resultado = -1;
            string orden = string.Empty;  
            if (accion == "Agregar")
                orden = "insert into Productos value (" + objetoProducto.p_codigo + ",'" + objetoProducto.p_descripcion + "', " + objetoProducto.p_stock + ");";

            if (accion == "Modificar")
                orden = "update Productos set Descripción='" + objetoProducto.p_descripcion + "', Stock=" + objetoProducto.p_stock + "where Codigo = " + objetoProducto.p_codigo + "; ";
         
            if(accion == "Eliminar")
                orden = "delete into Productos value" + objetoProducto.p_codigo + ",'" + objetoProducto.p_descripcion + "', " + objetoProducto.p_stock + ");";
           // No se si el delete esta bien  //

            OleDbCommand cmd = new OleDbCommand(orden, conexion);
            try
            {
                AbrirConexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception fail)
            {
                throw new Exception("Se encontro un error al tratar de guardar, eliminar o modificar un producto", fail);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;
        }

        public DataSet ListadoProducto(string list)
        {
            string orden = string.Empty;
            if (list != "Todos")
                orden = "select * from Producto where Codigo = " + int.Parse(list) + ";";
            else
                orden = "select * from Producto;";

            OleDbCommand cmd = new OleDbCommand(orden, conexion);
            DataSet DSet = new DataSet();
            OleDbDataAdapter DAdapter = new OleDbDataAdapter();
            try
            {
                AbrirConexion();
                cmd.ExecuteNonQuery();
                DAdapter.SelectCommand = cmd;
                DAdapter.Fill(DSet);
            }

            catch (Exception fail)
            {
                throw new Exception("Ocurrio un error al usar la lista", fail);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return DSet;
        }


    }
}
