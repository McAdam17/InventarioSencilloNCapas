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
    public static class dat_Producto
    {
        public static DataTable ObtenerTodosProductos()
        {
            IDbConnection _conn = dat_Conexion.Conexion();
            SqlDataReader sqlReader = null;
            DataTable tablaRes = new DataTable();
            _conn.Open();
            try
            {
                SqlCommand _Command = new SqlCommand("",_conn as SqlConnection);
                _Command.CommandType = CommandType.StoredProcedure;
                _Command.CommandText = "sp_MostrarTodosProductos";
                _Command.Parameters.Clear();
                sqlReader = _Command.ExecuteReader();
                if (sqlReader.HasRows)
                    tablaRes.Load(sqlReader);
            }catch (Exception)
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

        public static int AgregarProducto(Producto pEN)
        {
            IDbConnection _conn = dat_Conexion.Conexion();
            _conn.Open();

            SqlCommand _Commad = new SqlCommand("sp_insertarProducto", _conn as SqlConnection);
            _Commad.CommandType = CommandType.StoredProcedure;
            _Commad.Parameters.Add(new SqlParameter("@nombre", pEN.nombre));
            _Commad.Parameters.Add(new SqlParameter("@precio", pEN.precio));
            _Commad.Parameters.Add(new SqlParameter("@categoria", Convert.ToInt64(pEN.categoria)));
            _Commad.Parameters.Add(new SqlParameter("@stock", pEN.stock));
            _Commad.Parameters.Add(new SqlParameter("@unidad", Convert.ToInt64(pEN.unidad)));
            int resultado = 0;
            try
            {
                resultado = _Commad.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally{
                _conn.Close();
            }
            return resultado;
        }


        public static int ActualizarStock(Producto pEN)
        {
            IDbConnection _conn = dat_Conexion.Conexion();
            _conn.Open();

            SqlCommand _Commad = new SqlCommand("sp_actualizarStockProducto", _conn as SqlConnection);
            _Commad.CommandType = CommandType.StoredProcedure;
            _Commad.Parameters.Add(new SqlParameter("@id", pEN.id));
            _Commad.Parameters.Add(new SqlParameter("@stock", pEN.stock));

            int resultado = _Commad.ExecuteNonQuery();
            _conn.Close();
            return resultado;
        }



        
        
    }
}
