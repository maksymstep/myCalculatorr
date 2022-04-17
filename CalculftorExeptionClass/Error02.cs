using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculftorExeptionClass
{
    [Serializable]
    public class Error02 : Exception
    {
        private static string errorl = "";
        public static string errorll { get { return errorl; } }
        public Error02()
        {
            errorl = "Невідомий оператор на <i> символі.";
        }

        public Error02(string message)
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
