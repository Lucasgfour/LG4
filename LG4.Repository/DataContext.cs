using Microsoft.EntityFrameworkCore;

namespace LG4.Repository {
    public class DataContext : DbContext {

        private string connectionString = "";

        public DataContext() {

            this.connectionString = RepositoryResolver.ConnectionString;

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) {

            options.UseMySql(this.connectionString, ServerVersion.AutoDetect(connectionString));

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            

        }

    }
}
