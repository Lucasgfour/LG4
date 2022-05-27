using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG4.Commom.Tools {
    public static class DateManipulation {

        public static DateTime GetNow() {

            return DateTime.Now;

        }

        public static string NowForStringFile() {

            return DateTime.Now.ToString("HH:mm:ss - dd/MM/yyyy - ddd").ToUpper();

        }

    }
}
