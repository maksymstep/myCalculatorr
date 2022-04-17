using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculftorExeptionClass
{
    [Serializable]
    public class Error08 : Exception
    {
        private static string errorl = "";
        public static string errorll { get { return errorl; } }
        public Error08()
        {
            errorl = "Сумарна кількість чисел і операторів перевищує 30.";
        }

        public Error08(string message)
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
