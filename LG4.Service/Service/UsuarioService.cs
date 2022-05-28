using LG4.Commom.Tools;
using LG4.Data.Model;
using LG4.Repository.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG4.Service.Service {
    public static class UsuarioService {

        public static Usuario Login(string usuario, string senha) {

            var user = UsuarioRepository.Login(usuario, StringEncrypt.MD5Generate(senha));

            if (user == null)
                throw new Exception("Usuário / Senha inválido.");

            return user;

        }

    }
}
