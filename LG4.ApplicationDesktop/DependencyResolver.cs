using MaterialSkin;
using MaterialSkin.Controls;

namespace LG4.ApplicationDesktop {
    public static class DependencyResolver {

        public static void FormToTheme(MaterialForm form) {
            MaterialSkinManager.Instance.AddFormToManage(form);
        }

        public static void Resolver() {

            ThemeResolver();

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
