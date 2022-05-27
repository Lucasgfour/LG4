using LG4.Commom.Rules;
using LG4.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG4.Data.Rules {
    public static class DatabaseConnectionRules {

        public static Notifications onInsertOrUpdate(DatabaseConnection x) {

            ObjectRules rules = new ObjectRules();

            rules.isNullOrEmpty(x.Host, "Favor informar o Host.");
            rules.isNullOrEmpty(x.Name, "Favor informar um apelido para a conexão.");
            rules.isNullOrEmpty(x.User, "Favor informar o usuário para conexão.");
            rules.isNullOrEmpty(x.Password, "Favor informar a senha para conexão.");
            rules.isLessOrEqual(x.Port, 0, "Favor informar uma porta valida.");

            return rules.notifications;

        }

    }
}
