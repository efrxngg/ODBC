using Odbc.Entitys;
using Odbc.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Odbc.App
{
    public class CrudUsuarioImpl
    {
        private ICrudUsuario _objUsuario;

        public int SaveUser(User user)
        {
            return _objUsuario.SaveUser(user);
        }

        public CrudUsuarioImpl(ICrudUsuario objUsuario)
        {
            _objUsuario = objUsuario;
        }

        public void FindAllUsuarios()
        {
            var lista = _objUsuario.FindAllUsers();
            listarUsuarios(lista);
        }

        public int UpdateUser(User user, int id)
        {
            return _objUsuario.UpdateUser(user, id);
        }

        public int DeleteUser(int id) 
        {
            return _objUsuario.DeleteUser(id);
        }

        private void listarUsuarios(List<User> lista)
        {
            foreach (var user in lista)
            {
                WriteLine($"{user.Id} {user.Nombre} {user.Cedula}");
            }
        }
    }
}
