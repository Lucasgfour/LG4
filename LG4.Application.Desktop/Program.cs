namespace LG4.Desktop {
    internal static class Program {

        [STAThread]
        static void Main() {

            ApplicationConfiguration.Initialize();
            LG4.Desktop.DependencyResolver.Resolver();
            System.Windows.Forms.Application.Run(new LG4.Application.Desktop.UI.Infra.A0001_Login_Screen());

        }

    }
}