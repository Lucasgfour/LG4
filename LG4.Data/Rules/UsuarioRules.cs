using LG4.Commom.Rules;
using LG4.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG4.Data.Rules {
    public static class UsuarioRules {

        public static Notifications onInsert(Usuario u) {

            ObjectRules rules = new ObjectRules();

            rules.isNullOrEmpty(u.nome, "Favor informar o nome do usuário.");
            rules.isNullOrEmpty(u.usuario, "Favor informar o usuário para login.");
            rules.isNullOrEmpty(u.senha, "Favor informar uma senha.");

            return rules.notifications;

        }

        public static Notifications onUpdate(Usuario u) {

            ObjectRules rules = new ObjectRules();

            rules.isNullOrEmpty(u.nome, "Favor informar o nome do usuário.");
            rules.isNullOrEmpty(u.usuario, "Favor informar o usuário para login.");
            rules.isNullOrEmpty(u.senha, "Favor informar uma senha.");

            rules.isTrue(u.situacao == Enums.UsuarioSituacao.Desativado, "Usuário foi desativado, não é possível alterar o mesmo.");

            return rules.notifications;

        }

    }
}
