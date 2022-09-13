using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odbc.Interfaces
{
    public interface IConnectionDB
    {
        public SqlConnection Conectar();
        public void Desconectar();
    }
}
