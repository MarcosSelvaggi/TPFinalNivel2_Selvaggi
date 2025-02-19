using System;
using System.Data.SqlClient;

namespace Datos
{
    public class AccesoADatos
    {
        private SqlConnection conexion;
        public SqlCommand comando;
        private SqlDataReader lector;

        public SqlDataReader Lector
        {
            get
            {
                return lector;
            }
        }
        public AccesoADatos()
        {
            //Esto debería asegurarse de funcionar en casi cualquier server
            conexion = new SqlConnection("server=localhost; database=CATALOGO_DB; integrated security=true;");
            comando = new SqlCommand();
        }      

        public void ejecutarQuery()
        {
            try
            {
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int ejecutarNonQuery()
        {
            int rowsAffectadas = 0;
            try
            {
                comando.Connection = conexion;
                conexion.Open();
                rowsAffectadas = comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
            return rowsAffectadas;
        }

        public void setearConsulta(string query)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = query;
        }

        public void agregarParametros(string key, object value)
        {
            comando.Parameters.AddWithValue(key, value);
        }

        public void cerrarConexion()
        {
            if (lector != null)
            {
                lector.Close();
            }
            conexion.Close();
        }
    }
}
