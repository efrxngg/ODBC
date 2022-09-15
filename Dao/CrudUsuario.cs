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
        public int SaveUser(Usuario user)
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

        public List<Usuario> FindAllUsers()
        {
            var list = new List<Usuario>();
            _cone = new ConnectionDB(_cadenaConexion);
            var cursor = _cone.Conectar();

            try
            {
                SqlCommand sqlCommand = new SqlCommand("select * from usuario", cursor);
                var reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Usuario
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


    }
    #endregion
}
