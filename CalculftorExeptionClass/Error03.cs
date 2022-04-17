using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculftorExeptionClass
{
    [Serializable]
    public class Error03 : Exception
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
        public Error03()
        {
            errorl = "Невірна синтаксична конструкція вхідного виразу.";
        }

        public Error03(string message)
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
