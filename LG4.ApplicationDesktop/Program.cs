using LG4.ApplicationDesktop.UI.Forms.Infra;

namespace LG4.ApplicationDesktop {
    internal static class Program {

        [STAThread]
        static void Main() {

            DependencyResolver.Resolver();
            ApplicationConfiguration.Initialize();
            Application.Run(new A0001_Login());

        }
    }
}