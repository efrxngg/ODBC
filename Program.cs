using static System.Console;
using Odbc.Dao;

namespace Odbc
{
    class Program
    {
        static void Main()
        {
            WriteLine("Conexion A Base de datos SQL Server");
            //var cone = new ConnectionDB("Data Source=localhost;Initial Catalog=master;User ID=sa;Password=Adm1n2002;Application Name=introduccion; Encrypt=False");
            //var cone = new ConnectionDB("");
            //WriteLine(cone.Conectar());

            CrudUsuario crudUsuario = new CrudUsuario();
            var test = crudUsuario.findAllUsers();


        }
    }
}
