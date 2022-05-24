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

namespace LG4.Application.Desktop.UI.Infra {
    public partial class A0001_Login_Screen : MaterialForm {
        public A0001_Login_Screen() {
            InitializeComponent();
            DependencyResolver.FormResolver(this);
        }
    }
}
