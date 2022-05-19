using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG4.Commom.Rules {
    public class ObjectRules {

        public Notifications notifications = new Notifications();

        public ObjectRules() { }

        public void HasGreather(int value, int compare, string message) {

            if(value > compare) notifications.Add(message);

        }

    }
}
