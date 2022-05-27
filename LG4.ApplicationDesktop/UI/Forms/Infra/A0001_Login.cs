using MaterialSkin.Controls;

namespace LG4.ApplicationDesktop.UI.Forms.Infra {
    public partial class A0001_Login : MaterialForm {
        public A0001_Login() {

            InitializeComponent();
            DependencyResolver.FormToTheme(this);

        }

        private void Teste(object sender, EventArgs e) {
            label1.Text = lG4TextBox1.MaskCustom;
        }
    }
}
