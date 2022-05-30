using LG4.Commom.Tools;

namespace LG4.Repository {
    public static class RepositoryResolver {

        public static String ConnectionString { get; private set; } = "";

        public static void Configure(String connectionString) {

            ConnectionString = connectionString;

        }

        public static DataContext GetContext() {

            return new DataContext();

        }

        public static string GetMigrationsString() {

            string path = $"{Path.GetPathRoot(Environment.SystemDirectory)}LG4\\cnnStr.lg4";

            string cnnString = FileManipulation.ReadText(path);

            return cnnString;

        }


    }
}
