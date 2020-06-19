using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    static class dat_Conexion
    {
        private static string Conn = @"Data Source=localhost;Initial Catalog=inventario;Persist Security Info=True;User ID=mota;Password=root";

        public static IDbConnection Conexion()
        {
            return new SqlConnection(Conn);
        }

        public static IDbCommand ObtenerComando(string pComando, IDbConnection pConn)
        {
            return new SqlCommand(pComando,pConn as SqlConnection);
        }



    }
}
