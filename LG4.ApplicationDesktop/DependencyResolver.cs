using LG4.Commom;
using LG4.Commom.Tools;
using LG4.Data.Model;
using LG4.Repository;
using MaterialSkin;
using MaterialSkin.Controls;

namespace LG4.ApplicationDesktop {
    public static class DependencyResolver {

        public static void FormToTheme(MaterialForm form) {
            MaterialSkinManager.Instance.AddFormToManage(form);
        }

        public static void ExceptionResolver(Exception exception, bool stackTrace = false) {

            ExceptionTreatment.SaveException(exception);

            MessageBox.Show($"{exception.Message}", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        public static void ConnectionResolver(DatabaseConnection connection) {

            var strConnection = $"server={connection.Host}; port={connection.Port}; database={connection.Database}; user={connection.User}; password={connection.Password}";

            RepositoryResolver.Configure(strConnection);

        }

        public static void Resolver() {

            ThemeResolver();
            WorkspaceResolver.Resolver(Application.StartupPath);

        }

        private static void ThemeResolver() {

            var primary = Primary.Cyan800;
            var dark = Primary.Cyan900;
            var light = Primary.Cyan700;
            var accent = Accent.Cyan700;
            var textShade = TextShade.WHITE;

            var colors = new ColorScheme(primary, dark, light, accent, textShade);

            MaterialSkinManager.Instance.ColorScheme = colors;

        }


    }
}
