using LG4.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG4.Repository.Dao {
    public static class UsuarioRepository {

        public static Usuario Login(string usuario, string password) {

            var context = RepositoryResolver.GetContext();

            var result = context.Usuarios
                .Where(x => x.usuario.Equals(usuario) && x.senha.Equals(password))
                .FirstOrDefault();

            context.Dispose();

            return result;

        }

        public static Usuario Consult(int id) {

            var context = RepositoryResolver.GetContext();

            var result = context.Usuarios
                            .Where(x => x.id == id)
                            .FirstOrDefault();

            context.Dispose();

            return result;

        }

        public static void Add(Usuario usuario) {

            var context = RepositoryResolver.GetContext();

            context.Usuarios.Add(usuario);

            context.SaveChanges();

            context.Dispose();

        }

        public static void Update(Usuario usuario) {

            var user = Consult(usuario.id);

            var context = RepositoryResolver.GetContext();

            if (user == null)
                throw new Exception("Não encontrado o registro selecionado no banco.");

            context.Usuarios.Update(usuario);

            context.SaveChanges();

            context.Dispose();

        }

    }
}
