using LG4.Commom;
using LG4.Commom.Tools;
using LG4.Data.Model;
using LG4.Data.Rules;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG4.Service.Service {
    public static class DatabaseConnectionService {

        public static List<DatabaseConnection> GetAll() {

            string path = WorkspaceResolver.GetWorkspacePath() + "\\lg4.cnn";

            if (!File.Exists(path))
                return new List<DatabaseConnection>();

            string jsonTextEncrypted = FileManipulation.ReadText(path);

            string jsonText = StringEncrypt.Decrypt(jsonTextEncrypted);

            List<DatabaseConnection> connections = JsonConvert.DeserializeObject<List<DatabaseConnection>>(jsonText);

            if(connections == null) 
                return new List<DatabaseConnection>();

            return connections;

        }

        public static void Save(List<DatabaseConnection> connections) {

            connections.ForEach((cnn) => {

                DatabaseConnectionRules.onInsertOrUpdate(cnn).Validation();

            });

            string path = WorkspaceResolver.GetWorkspacePath() + "\\lg4.cnn";

            string jsonText = JsonConvert.SerializeObject(connections);

            string jsonEncrypted = StringEncrypt.Encrypt(jsonText);

            FileManipulation.SaveText(path, jsonEncrypted);

        }

    }
}
