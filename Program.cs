using static System.Console;
using Odbc.Dao;
using Odbc.App;

namespace Odbc
{
    class Program
    {
        static void Main()
        {
            WriteLine("Conexion A Base de datos SQL Server");
            CrudUsuarioImpl crudUsuarioImpl = new CrudUsuarioImpl(new CrudUsuario());
            crudUsuarioImpl.findAllUsuarios();

        }
    }
}
