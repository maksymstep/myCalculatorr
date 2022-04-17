using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculftorExeptionClass
{
    [Serializable]
    public class Error01 : Exception
    {
        private static string errorl = "";
        public static string errorll { get { return errorl; } }
        public Error01()
        {
            errorl = "Неправильна структура в дужках, помилка на <i> символі.";
        }

        public Error01(string message)
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
