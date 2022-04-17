using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculftorExeptionClass
{
    [Serializable]
    public class Error05 : Exception
    {
        private static string errorl = "";
        public static string errorll
        {
            get
            {
                return errorl;
            }
            set
            {
                errorl = value;
            }
        }
        public Error05()
        {
            errorl = "Незавершений вираз.";
        }
        public Error05(string message)
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
