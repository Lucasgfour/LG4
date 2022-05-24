using Microsoft.EntityFrameworkCore;

namespace LG4.Repository {
    public class DataContext : DbContext {

        private string connectionString = "";

        public DataContext() {

            // Definição de variável de conexão é realizada no RepositoryResolver
            this.connectionString = RepositoryResolver.ConnectionString;

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) {

            options.UseMySql(this.connectionString, ServerVersion.AutoDetect(connectionString));

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            // Aplicação de Map deve ser realizado nessa classe
            RepositoryMap.ResolverMap(modelBuilder);

        }

    }
}
