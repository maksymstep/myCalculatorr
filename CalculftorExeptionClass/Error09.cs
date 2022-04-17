using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculftorExeptionClass
{
    [Serializable]
    public class Error09 : Exception
    {
        private static string errorl = "";
        public static string errorll { get { return errorl; } }
        public Error09()
        {
            errorl = "Помилка ділення на 0.";
        }

        public Error09(string message)
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
