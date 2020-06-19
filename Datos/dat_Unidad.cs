using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public static class dat_Unidad
    {
        public static DataTable ObtenerTodosUnidades()
        {
            IDbConnection _conn = dat_Conexion.Conexion();
            SqlDataReader sqlReader = null;
            DataTable tablaRes = new DataTable();
            _conn.Open();
            try
            {
                SqlCommand _Command = new SqlCommand("", _conn as SqlConnection);
                _Command.CommandType = CommandType.StoredProcedure;
                _Command.CommandText = "sp_MostrarUnidades";
                _Command.Parameters.Clear();
                sqlReader = _Command.ExecuteReader();
                if (sqlReader.HasRows)
                    tablaRes.Load(sqlReader);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (sqlReader != null)
                {
                    if (!sqlReader.IsClosed)
                        sqlReader.Close();
                    sqlReader.Dispose();
                }
                _conn.Close();
            }
            return tablaRes;
        }
    }
}
