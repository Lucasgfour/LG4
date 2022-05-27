using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG4.Data.Model {
    public class DatabaseConnection {

        public string Name { get; set; } = "";
        public string Host { get; set; } = "";
        public int Port { get; set; }
        public string User { get; set; } = "root";
        public string Password { get; set; } = "";
        public string Database { get; set; } = "lg4";

        public DatabaseConnection() { }

        public DatabaseConnection(string name, string host, int port, string user, string password, string database) {

            this.Name = name;
            this.Host = host;
            this.Port = port;
            this.User = user;
            this.Password = password;
            this.Database = database;
        }

    }
}
