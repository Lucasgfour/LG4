using LG4.ApplicationDesktop.UI.Forms.Infra;

namespace LG4.ApplicationDesktop {
    internal static class Program {

        [STAThread]
        static void Main() {

            DependencyResolver.Resolver();
            ApplicationConfiguration.Initialize();

            try {

                Application.Run(new A0003_HomePage());

            } catch(Exception exception) {

                DependencyResolver.ExceptionResolver(exception, true);

            }

        }
    }
}