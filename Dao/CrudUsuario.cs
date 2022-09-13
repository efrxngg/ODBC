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
        #region
        private ConnectionDB _cone;
        private string _cadenaConexion = "Data Source=localhost;Initial Catalog=introduccion;User ID=sa;Password=Adm1n2002;Application Name=usuario; Encrypt=False";
        #endregion
        public List<Usuario> findAllUsers()
        {
            var list = new List<Usuario>();
            _cone = new ConnectionDB(_cadenaConexion);
            var cursor = _cone.Conectar();

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

            return list;
        }
    }
}
