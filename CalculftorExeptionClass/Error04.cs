using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculftorExeptionClass
{
    [Serializable]
    public class Error04 : Exception
    {
        private static string errorl = "";
        public static string errorll
        {
            get { return errorl; }
        }
        public Error04()
        {
            errorl = "Два підряд оператори на <i> символі.";
        }

        public Error04(string message)
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
