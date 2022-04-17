using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculftorExeptionClass
{
    [Serializable]
    public class Error06 : Exception
    {
        private static string errorl = "";
        public static string errorll { get { return errorl; } }
        public Error06()
        {
            errorl = "Дуже мале, або дуже велике значення числа для int. Числа повинні бути в межах від -2147483648 до 2147483647";
        }

        public Error06(string message)
        {
            errorl = message;
        }
        public override string Message
        {
            get
            {
                return errorl;
            }
        }
    }
}
