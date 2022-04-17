using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcClass
{
    public class Calc
    {
        /// <summary>
        /// Функція складання числа а і b
        /// </summary>
        /// <param name="a">доданок</param>
        /// <param name="b">доданок</param>
        /// <returns>сума</returns>
        public static int Sum(long a, long b)
        {
            long r = a + b;

            if (r < int.MinValue || r > int.MaxValue)
                throw new OverflowException();
            return (int)r;
        }

        /// <summary>
        /// функція віднімання чисел а і b
        /// </summary>
        /// <param name="a">зменшуване</param>
        /// <param name="b">від’ємне</param>
        /// <returns>різниця</returns>
        public static int Sub(long a, long b)
        {
            long r = a - b;

            if (r < int.MinValue || r > int.MaxValue)
                throw new OverflowException();
            return (int)r;
        }
        /// <summary>
        /// функція множення чисел а і b
        /// </summary>
        /// <param name="a">множник</param>
        /// <param name="b">множник</param>
        /// <returns>добуток</returns>
        public static int Mul(long a, long b)
        {
            long r = a * b;

            if (r < int.MinValue || r > int.MaxValue)
                throw new OverflowException();
            return (int)r;
        }
        /// <summary>
        /// функція знаходження частки
        /// </summary>
        /// <param name="a">ділене</param>
        /// <param name="b">дільник</param>
        /// <returns>частка</returns>
        public static int Div(long a, long b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }

            long r = a / b;

            if (r < int.MinValue || r > int.MaxValue)
                throw new OverflowException();
            return (int)r;
        }

        /// <summary>
        /// функція ділення по модулю
        /// </summary>
        /// <param name="a">ділене</param>
        /// <param name="b">дільник</param>
        /// <returns>остача</returns>
        public static int Mod(long a, long b)
        {
            if (b == 0)
                throw new DivideByZeroException();
            long r = a % b;

            if (r < int.MinValue || r > int.MaxValue)
                throw new OverflowException();
            return (int)r;
        }
        /// <summary>
        /// унарний плюс 
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int P(long a)
        {
            long r = Convert.ToInt32(Math.Abs(a));
            if (r < int.MinValue || r > int.MaxValue)
                throw new OverflowException();
            return (int)r;
        }
        /// <summary>
        /// унарний мінус 
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int M(long a)
        {
            long r = Convert.ToInt32(Math.Abs(a));
            if (r < int.MinValue || r > int.MaxValue)
                throw new OverflowException();
            return (int)r;
        }

    }
}

