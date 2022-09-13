using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Odbc.Dao
{
    public class ConnectionDB
    {
        #region Atributos
        private SqlConnection _connection;
        #endregion


        #region Constructores
        public ConnectionDB(string cadenaConexion)
        {
            this._connection = new SqlConnection(cadenaConexion);
        }
        #endregion


        #region Metodos
        public SqlConnection Conectar()
        {
            try
            {
                //Habre la conexion
                _connection.Open();
                return _connection;
            }
            catch (SqlException se)
            {
                WriteLine($"Error capturado: {se.Message}");
            }
            catch (InvalidOperationException io)
            {
                WriteLine($"Error capturado: {io.Message}");
            }
            return null;
        }


        public void Desconectar()
        {
            try
            {
                //Cierra la conexion
                _connection.Close();
                //Libera los recursos
                _connection.Dispose();
            }
            catch (SqlException se)
            {
                WriteLine($"Error capturado: {se.Message}");
            }
            finally
            {
                _connection = null;
            }
        }
        #endregion

    }
}
