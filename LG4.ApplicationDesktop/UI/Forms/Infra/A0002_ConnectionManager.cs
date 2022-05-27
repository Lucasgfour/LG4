using LG4.ApplicationDesktop.Controller;
using LG4.ApplicationDesktop.UI.Controls;
using LG4.Data.Model;
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
    public partial class A0002_ConnectionManager : MaterialForm {

        private DatabaseConnection selected = new DatabaseConnection();

        public A0002_ConnectionManager() {
            InitializeComponent();
            DependencyResolver.FormToTheme(this);
        }

        private void Loading(object sender, EventArgs e) {

            RefreshData();

        }

        private void RefreshData() {

            list_conexoes.Items.Clear();

            ClearFields();

            selected = new DatabaseConnection();

            DatabaseConnectionController.GetAll();

            DatabaseConnectionController.connections.ForEach((connection) => {

                var item = new ListViewItem();

                item.Text = connection.Name;
                item.SubItems.Add($"{connection.Host}:{connection.Port}");

                list_conexoes.Items.Add(item);

            });

        }

        private void ClearFields() {

            pn_fields.Controls.OfType<LG4TextBox>().ToList().ForEach((field) => {

                field.Text = "";

                field.ReadOnly = (field.Name.Equals("txt_name") && !selected.Name.Equals(""));
                field.Visible = !(field.Name.Equals("txt_password") && !selected.Name.Equals(""));

            });

            lab_senha.Visible = txt_password.Visible;

        }

        private void Click_NewConnection(object sender, EventArgs e) {

            selected = new DatabaseConnection();

            ClearFields();

            txt_name.Focus();

        }

        private void ClickSave(object sender, EventArgs e) {

            if (!txt_name.ReadOnly)
                selected.Name = txt_name.Text;

            selected.Host = txt_host.Text;

            var port = 0;
            int.TryParse(txt_port.Text, out port);

            selected.Port = port;
            selected.User = txt_user.Text;

            if (txt_password.Visible)
                selected.Password = txt_password.Text;

            selected.Database = txt_database.Text;
            
            try {

                if (txt_name.ReadOnly)
                    DatabaseConnectionController.Update(selected);

                if (!txt_name.ReadOnly)
                    DatabaseConnectionController.Add(selected);

            } catch (Exception exception) {

                DependencyResolver.ExceptionResolver(exception);

            }

            RefreshData();

        }

        private void ClickSelecionarLista(object sender, EventArgs e) {

            if (list_conexoes.FocusedItem == null)
                return;

            if (list_conexoes.FocusedItem.Index < 0)
                return;

            selected = DatabaseConnectionController.connections.ElementAt(list_conexoes.FocusedItem.Index);

            ClearFields();

            pn_fields.Controls.OfType<LG4TextBox>().ToList().ForEach((field) => {

                var propertyName = field.Name.Replace("txt_", "");
                var property = selected.GetType().GetProperties().Where(x => x.Name.ToLower().Equals(propertyName)).FirstOrDefault();

                if (property != null)
                    field.Text = property.GetValue(selected).ToString();

            });

        }

        private void ClickRemoveSelected(object sender, EventArgs e) {

            if (selected.Name.Equals(""))
                return;

            DatabaseConnectionController.Remove(selected);

            RefreshData();

        }
    }
}
