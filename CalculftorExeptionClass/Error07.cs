using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculftorExeptionClass
{
    [Serializable]
    public class Error07 : Exception
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
        public Error07()
        {
            errorl = "Дуже довгий вираз. Максмальная довжина — 65536 символів";
        }

        public Error07(string message)
        {
            errorl = message;
        }
    }
}
