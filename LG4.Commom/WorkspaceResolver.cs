using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG4.Commom {
    public static class WorkspaceResolver {

        private static string Path = "";

        public static void Resolver(string path) {

            Path = path;

        }

        public static string GetWorkspacePath() {

            if (!Directory.Exists(Path))
                throw new Exception("Diretório informado para Workspace não é valido.");

            return Path;

        }

    }
}
