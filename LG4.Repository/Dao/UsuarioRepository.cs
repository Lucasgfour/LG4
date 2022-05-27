using LG4.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG4.Repository.Dao {
    public static class UsuarioRepository {

        public static Usuario Login(string usuario, string password) {

            var result = RepositoryResolver
                .GetContext()
                .Usuarios
                .Where(x => x.usuario.Equals(usuario) && x.senha.Equals(password))
                .FirstOrDefault();

            return result;

        }

        public static Usuario Consult(int id) {

            var result = RepositoryResolver
                            .GetContext()
                            .Usuarios
                            .Where(x => x.id == id)
                            .FirstOrDefault();

            return result;

        }

        public static void Add(Usuario usuario) {

            RepositoryResolver.GetContext().Usuarios.Add(usuario);

            RepositoryResolver.GetContext().SaveChanges();

        }

    }
}
