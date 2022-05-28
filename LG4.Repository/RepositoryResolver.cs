namespace LG4.Repository {
    public static class RepositoryResolver {

        public static String ConnectionString { get; private set; } = "";

        public static void Configure(String connectionString) {

            ConnectionString = connectionString;

        }

        public static DataContext GetContext() {

            return new DataContext();

        }


    }
}
