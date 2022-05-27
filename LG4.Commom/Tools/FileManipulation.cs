using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG4.Commom.Tools {
    public static class FileManipulation {

        public static string ReadText(string path) {

            if (!File.Exists(path))
                throw new Exception($"Não foi encontrado nenhum arquivo de caminho '{path}'");

            string text = File.ReadAllText(path, Encoding.Default);

            return text;

        }

        public static void SaveText(string path, string text) {

            File.WriteAllText(path, text, Encoding.Default);

        }

    }
}
