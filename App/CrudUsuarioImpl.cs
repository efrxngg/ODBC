﻿using Odbc.Entitys;
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

        public CrudUsuarioImpl(ICrudUsuario objUsuario)
        {
            _objUsuario = objUsuario;
        }

        public void findAllUsuarios()
        {
            var lista = _objUsuario.findAllUsers();
            listarUsuarios(lista);
        }


        private void listarUsuarios(List<Usuario> lista)
        {
            foreach (var user in lista)
            {
                WriteLine($"{user.Id} {user.Nombre} {user.Cedula}");
            }
        }
    }
}