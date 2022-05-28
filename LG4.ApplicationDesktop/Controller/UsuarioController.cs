using LG4.Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG4.ApplicationDesktop.Controller {
    public static class UsuarioController {

        public static bool Login(string usuario, string senha) {

            var user = UsuarioService.Login(usuario, senha);

            SessionStorage.logado = user;

            return user != null;

        }

    }
}
