using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG4.Commom.Rules {
    public class ObjectRules {

        public Notifications notifications = new Notifications();

        public ObjectRules() { }

        public void IsGreater(double value, double compare, string message) {

            if(value > compare) notifications.Add(message);

        }

        public void IsSmaller(double value, double compare, string message) {

            if (value < compare) notifications.Add(message);

        }

        public void IsSmallerOrEqual(double value, double compare, string message) {

            if (value <= compare) notifications.Add(message);

        }

        public void IsGreaterOrEqual(double value, double compare, string message) {

            if (value >= compare) notifications.Add(message);

        }



    }
}
