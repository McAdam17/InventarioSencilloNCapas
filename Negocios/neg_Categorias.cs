using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Negocios
{
    public static class neg_Categorias
    {
        public static DataTable obtenerTodasCategorias()
        {
            return dat_Categoria.ObtenerTodosCategorias();
        }
    }
}
