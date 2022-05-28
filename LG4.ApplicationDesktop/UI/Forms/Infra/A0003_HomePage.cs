using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LG4.ApplicationDesktop.UI.Forms.Infra {
    public partial class A0003_HomePage : MaterialForm {
        public A0003_HomePage() {

            InitializeComponent();
            DependencyResolver.FormToTheme(this);

        }

        private void Loading(object sender, EventArgs e) {

            var telaLogin = new A0001_Login();

            if (telaLogin.ShowDialog() != DialogResult.OK)
                Application.Exit();

            DrawTheme();
            SetValues();

        }

        private void DrawTheme() {

            var labTop = this.Controls.OfType<MaterialLabel>().Where(x => x.Name.Contains("_top_")).ToList();

            labTop.ForEach((lab) => {
                lab.BackColor = MaterialSkin.MaterialSkinManager.Instance.ColorScheme.PrimaryColor;
            });

        }

        private void SetValues() {

            lab_top_userName.Text = SessionStorage.logado.nome;

        }
    }
}
