using LG4.Data.Model;
using LG4.Service.Service;

namespace LG4.ApplicationDesktop.Controller {
    public static class DatabaseConnectionController {

        public static List<DatabaseConnection> connections { get; private set; } = new List<DatabaseConnection>();

        public static void GetAll() {

            connections = DatabaseConnectionService.GetAll();

        }

        public static void Add(DatabaseConnection connection) {

            GetAll();

            connections.ForEach((cnn) => {
                if (cnn.Name.Equals(connection.Name))
                    throw new Exception($"Já existe uma conexão cadastrada com esse nome !");
            });

            connections.Add(connection);

            DatabaseConnectionService.Save(connections);

        }

        public static void Update(DatabaseConnection connection) {

            GetAll();

            var update = false;

            connections.ForEach((cnn) => {
                if (cnn.Name.Equals(connection.Name)) {

                    cnn.Host = connection.Host;
                    cnn.Port = connection.Port;
                    cnn.User = connection.User;
                    cnn.Password = connection.Password;
                    cnn.Database = connection.Database;
                    update = true;

                }
            });

            if (!update)
                throw new Exception($"Não foi encontrado a conexão '{connection.Name}' na lista de conexões.");

            DatabaseConnectionService.Save(connections);

        }

        public static void Remove(DatabaseConnection connection) {

            GetAll();

            var newList = connections.Where(x => !x.Name.Equals(connection.Name)).ToList();

            if(newList.Count < connections.Count)
                DatabaseConnectionService.Save(newList);

        }

    }
}
