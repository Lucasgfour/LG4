using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG4.Commom.Tools {
    public static class ExceptionTreatment {

        public static void SaveException(Exception exception, bool stackTrace = false) {

            string path = WorkspaceResolver.GetWorkspacePath() + "\\error.log";

            StreamWriter writer = new StreamWriter(path, true);

            string strException = $"{DateManipulation.NowForStringFile()} -> {exception.Source} / {exception.Message}";

            writer.WriteLine(strException);

            if (stackTrace)
                writer.WriteLine($"StackTrace: {exception.StackTrace}");

            writer.Close();

        }

    }
}
