using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
using Entidades;

namespace CapaNegocios
{
    public class NegocioProductos
    {
        AdministracionProductos DatosObjProducto = new AdministracionProductos();

        public int abmProductos(string accion, Producto ObjProducto)
        {
            return DatosObjProducto.abmProducto(accion, ObjProducto);
        }
        public DataSet listadoProductos(string cual)
        {
            return DatosObjProducto.ListadoProducto(cual);
            
    }
    }
}
