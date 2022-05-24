using MaterialSkin;

namespace LG4.Application.Desktop {
    public static class DependencyResolver {

        // Adicionar um form a biblioteca MaterialSkin
        public static void FormResolver(MaterialSkin.Controls.MaterialForm form) {
            MaterialSkinManager.Instance.AddFormToManage(form);
        }

        public static void Resolver() {

            // Definição de cores do tema da biblioteca MaterialSkin
            FormThemeResolver();

            // Distribui valores de parâmetro do sistema
            SettingsResolver();

        }

        private static void SettingsResolver() {



        }

        private static void FormThemeResolver() {

            var material = MaterialSkin.MaterialSkinManager.Instance;

            var primaryColor = Primary.Cyan900;
            var darkColor = Primary.Cyan800;
            var lightColor = Primary.Cyan700;
            var accent = Accent.Cyan400;
            var textShade = TextShade.BLACK;

            material.ColorScheme = new ColorScheme(primaryColor, darkColor, lightColor, accent, textShade);

        }

    }
}
