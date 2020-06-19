using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
using System.Data;


namespace Negocios
{
    public static class neg_Producto
    {
        public static int AgregarProducto(Producto pEN)
        {
            return dat_Producto.AgregarProducto(pEN);
        }

        public static DataTable MostrarTodosProductos()
        {
            return dat_Producto.ObtenerTodosProductos();
        }

        public static int ActualizarStock(Producto pEN)
        {
            return dat_Producto.ActualizarStock(pEN);
        }
    }
}
