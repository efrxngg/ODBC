using static System.Console;
using Odbc.Dao;
using Odbc.App;
using Microsoft.Data.SqlClient;

namespace Odbc
{
    class Program
    {
        static void Main()
        {
            WriteLine("Conexion A Base de datos SQL Server");
            CrudUsuarioImpl crudUsuarioImpl = new CrudUsuarioImpl(new CrudUsuario());
            //crudUsuarioImpl.FindAllUsuarios(); Funciona
            WriteLine($"{crudUsuarioImpl.SaveUser(new Entitys.Usuario { Cedula = "095493112", Nombre = "Dario Carpio"})}"); //Funciona

        }
    }
}
