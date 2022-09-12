using static System.Console;
using Odbc.Dao;
using Microsoft.Data.SqlClient;
using System.Security;

namespace Odbc
{
    class Program
    {
        static void Main()
        {
            WriteLine("Conexion A Base de datos SQL Server");
            var cone = new ConnectionDB("Data Source=localhost:1433;Initial Catalog=master;User ID=sa;Password=Adm1n2002;Application Name=usuario");
            WriteLine(cone);


        }
    }
}
