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
        public int SaveUser(User user);
        public List<User> FindAllUsers();
        public int UpdateUser(User user, int id);
        public int DeleteUser(int id);
    }
}
