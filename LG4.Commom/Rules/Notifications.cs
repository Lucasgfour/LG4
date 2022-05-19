using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG4.Commom.Rules {
    public class Notifications {

        public List<String> notifications = new List<String>();

        public Notifications() { }

        public void Add(String message) {
            notifications.Add(message);
        }

        public void Validation() {

            if (notifications.Count > 0)
                throw new Exception(ShowAllNotifications());

        }

        public int CountNotifications() => notifications.Count;

        public String ShowAllNotifications() {

            String saida = "";

            notifications.ForEach(notification => { saida = saida + $"{notification}{Environment.NewLine}"; });

            return saida;

        }

    }
}
