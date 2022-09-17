using Microsoft.Data.SqlClient;
using Odbc.Entitys;
using Odbc.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Odbc.Dao
{
    public class CrudUsuario : ICrudUsuario
    {
        #region Atributos
        private ConnectionDB _cone;
        private string _cadenaConexion = "Data Source=localhost;Initial Catalog=introduccion;User ID=sa;Password=Adm1n2002;Application Name=usuario; Encrypt=False";
        #endregion

        #region Metodos
        public int SaveUser(User user)
        {
            _cone = new ConnectionDB(_cadenaConexion);
            var cursor = _cone.Conectar();

            try
            {
                SqlCommand sqlCommand = new SqlCommand("insert into usuario(cedula, nombre) values(@cedula, @nombre)", cursor);
                sqlCommand.Parameters.AddWithValue("@cedula", user.Cedula);
                sqlCommand.Parameters.AddWithValue("@nombre", user.Nombre);

                return sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
            return 0;

        }

        public List<User> FindAllUsers()
        {
            var list = new List<User>();
            _cone = new ConnectionDB(_cadenaConexion);
            var cursor = _cone.Conectar();

            try
            {
                SqlCommand sqlCommand = new SqlCommand("select * from usuario", cursor);
                var reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new User
                    {
                        Id = reader.GetInt32("id"),
                        Cedula = reader.GetString("cedula"),
                        Nombre = reader.GetString("nombre")
                    });
                }
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
            finally
            {
                _cone.Desconectar();
            }

            return list;
        }

        public int UpdateUser(User user, int id)
        {

            _cone = new ConnectionDB(_cadenaConexion);
            var cursor = _cone.Conectar();

            try
            {
                SqlCommand sqlCommand = new SqlCommand("update usuario set cedula=@cedula, nombre=@nombre where id=@id", cursor);
                sqlCommand.Parameters.AddWithValue("@cedula", user.Cedula);
                sqlCommand.Parameters.AddWithValue("@nombre", user.Nombre);
                sqlCommand.Parameters.AddWithValue("@id",id);

                return sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
            return 0;
        }

        public int DeleteUser(int id)
        {
            _cone = new ConnectionDB(_cadenaConexion);
            var cursor = _cone.Conectar();

            try
            {
                SqlCommand sqlCommand = new SqlCommand("delete from usuario where id=@id", cursor);
                sqlCommand.Parameters.AddWithValue("@id", id);

                return sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
            return 0;
        }
    }
    #endregion
}
