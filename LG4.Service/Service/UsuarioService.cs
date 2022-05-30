using LG4.Commom.Rules;
using LG4.Commom.Tools;
using LG4.Data.Model;
using LG4.Data.Rules;
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

        public static Usuario Consult(int id) {

            var users = UsuarioRepository.Consult(id);

            return users;

        }

        public static ICollection<Usuario> ListAll() {

            var users = UsuarioRepository.ListAll();

            return users;

        }

        public static void Add(Usuario usuario) {

            var notifications = UsuarioRules.onInsert(usuario);

            notifications.Validation();

            if (usuario.senha.Length < 32)
                usuario.senha = StringEncrypt.MD5Generate(usuario.senha);

            UsuarioRepository.Add(usuario);

        }

        public static void Update(Usuario usuario) {

            var notifications = UsuarioRules.onUpdate(usuario);

            notifications.Validation();

            if (usuario.senha.Length < 32)
                usuario.senha = StringEncrypt.MD5Generate(usuario.senha);

            UsuarioRepository.Update(usuario);

        }

    }
}
