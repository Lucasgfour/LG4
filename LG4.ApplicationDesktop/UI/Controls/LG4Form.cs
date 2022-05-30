using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG4.ApplicationDesktop.UI.Controls {
    public class LG4Form : MaterialForm {

        public string GetCodigoTela() {

            if(this.Name.Length > 5)
                return this.Name.Substring(0, 5);

            return "";

        }

        public LG4Form() {

            DependencyResolver.FormToTheme(this);
            this.Load += PermissionValidation;

        }

        private void PermissionValidation(object? sender, EventArgs e) {
            
            string codigoTela = this.GetCodigoTela();

        }
    }
}
