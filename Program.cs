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
            //crudUsuarioImpl.FindAllUsuarios(); // Funciona
            //WriteLine($"{crudUsuarioImpl.SaveUser(new Entitys.User { Cedula = "095493112", Nombre = "Dario Carpio"})}"); //Funciona
            //WriteLine($"{crudUsuarioImpl.UpdateUser(new Entitys.User { Cedula = "0954943114", Nombre = "Efren Galarza" }, 1)}"); //Funciona
            //WriteLine($"{crudUsuarioImpl.DeleteUser(1)}"); //Funciona

        }
    }
}
