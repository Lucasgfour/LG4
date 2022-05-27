using LG4.Data.Model;
using LG4.Repository.Map;
using Microsoft.EntityFrameworkCore;

namespace LG4.Repository {
    public static class RepositoryMap {

        public static void ResolverMap(ModelBuilder model) {

            model.ApplyConfiguration<Usuario>(new UsuarioMap());

        }

    }
}
