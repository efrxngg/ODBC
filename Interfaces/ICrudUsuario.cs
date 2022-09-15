using Odbc.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odbc.Interfaces
{
    public interface ICrudUsuario
    {
        public int SaveUser(Usuario user);
        public List<Usuario> FindAllUsers();
    }
}
