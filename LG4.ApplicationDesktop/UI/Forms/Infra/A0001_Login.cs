using LG4.ApplicationDesktop.Controller;
using MaterialSkin.Controls;

namespace LG4.ApplicationDesktop.UI.Forms.Infra {
    public partial class A0001_Login : MaterialForm {
        public A0001_Login() {

            InitializeComponent();
            DependencyResolver.FormToTheme(this);

        }

        private void Loading(object sender, EventArgs e) {

            RefreshConnections();

            var lastUser = Properties.ApplicationSettings.Default.LastUserSelected;

            if (!lastUser.Equals("")) {

                txt_user.Text = lastUser;

                this.Show();

                txt_password.Focus();

            }

        }

        private void Click_Connection_Manager(object sender, EventArgs e) {

            var a0002 = new A0002_ConnectionManager();

            if (a0002.ShowDialog() == DialogResult.None)
                RefreshConnections();

        }

        private void RefreshConnections() {

            cbx_connection.Items.Clear();

            var cnnSelected = Properties.ApplicationSettings.Default.LastSelectedConnection;

            DatabaseConnectionController.GetAll();

            DatabaseConnectionController.connections.ForEach((cnn) => {

                cbx_connection.Items.Add(cnn.Name);

                if (cnn.Name.Equals(cnnSelected))
                    cbx_connection.SelectedIndex = cbx_connection.Items.Count - 1;

            });

            if (cbx_connection.SelectedIndex < 0 && cbx_connection.Items.Count > 0)
                cbx_connection.SelectedIndex = 0;

        }

        private void ClickConnect(object sender, EventArgs e) {

            if(cbx_connection.Items.Count == 0) {
                MessageBox.Show("Não há conexão com banco de dados.");
                return;
            }

            var connection = DatabaseConnectionController.connections.ElementAt(cbx_connection.SelectedIndex);

            DependencyResolver.ConnectionResolver(connection);

            try {

                var sucesso = UsuarioController.Login(txt_user.Text, txt_password.Text);

                if (!sucesso)
                    return;

                Properties.ApplicationSettings.Default.LastSelectedConnection = cbx_connection.Text;
                Properties.ApplicationSettings.Default.LastUserSelected = txt_user.Text;
                Properties.ApplicationSettings.Default.Save();

                this.DialogResult = DialogResult.OK;
                this.Close();

            } catch(Exception erro) { MessageBox.Show(erro.Message); }


        }

    }
}
