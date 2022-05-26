using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG4.Commom.Rules {
    public class ObjectRules {

        public Notifications notifications = new Notifications();

        public ObjectRules() { }

        public void isGreater(double value, double compare, string message) {

            if(value > compare) notifications.Add(message);

        }

        public void isLess(double value, double compare, string message) {

            if (value < compare) notifications.Add(message);

        }

        public void isLessOrEqual(double value, double compare, string message) {

            if (value <= compare) notifications.Add(message);

        }

        public void isGreaterOrEqual(double value, double compare, string message) {

            if (value >= compare) notifications.Add(message);

        }

        public void isEqual(string value, string compare, string message) {

            if(value.Equals(compare)) notifications.Add(message);

        }

        public void isEqual(int value, int compare, string message) {

            if (value == compare) notifications.Add(message);

        }

        public void isLengthGreaterThan(string value, int lenght, string message) {

            if (value.Length > lenght) notifications.Add(message);

        }

        public void isLengthLessThan(string value, int lenght, string message) {

            if (value.Length < lenght) notifications.Add(message);

        }

        public void isNull(object value, string message) {

            if (value == null) notifications.Add(message);

        }

        public void isNullOrEmpty(string? value, string message) {

            string newValue = value == null ? "" : value;

            if (newValue == null) notifications.Add(message);

            #pragma warning disable CS8604 // Possível argumento de referência nula.
            isEqual(newValue, "", message);
            #pragma warning restore CS8604 // Possível argumento de referência nula.

        }


    }
}
