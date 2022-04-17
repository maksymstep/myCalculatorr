using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculftorExeptionClass;
using CalcClass;


namespace AnalaizerClass
{
    public class Analizer
    {
        
        private static int EP = 0;
        
        public static string EX = "";
        
        public static bool Message = true;
        
        public static bool CheckEx()
        {
            
            if (EX.Length > 65536)
                throw new Error07();

            Stack st = new Stack();

           
            if (EX[0] < '0')
                if (EX[0] != '-' && EX[0] != '(')
                {
                    EP = 0;
                    return false;
                }

            
            if (EX[EX.Length - 1] < '0' && EX[EX.Length - 1] != ')')
            {
                EP = EX.Length - 1;
                return false;
            }

       
            for (int i = 0; i < EX.Length - 1; i++)
            {
                if ((EX[i] >= '0' && EX[i] <= '9') && EX[i + 1] == '(')
                {
                    EP = i + 1;
                    return false;
                }

                if (EX[i] < '0' && EX[i] >= '*') 
                {
                    if (EX[i + 1] < '0' && EX[i + 1] != '(')
                    {
                        EP = i + 1;
                        return false;
                    }
                }
                if (EX[i] == '(')
                {
                    if (EX[i + 1] != '-' && EX[i + 1] != '(' && EX[i + 1] <= '0')
                    {
                        EP = i + 1;
                        return false;
                    }
                    else
                        st.Push(EX[i]);
                }

                if (EX[i] == ')' && EX[i + 1] >= '0')
                {
                    EP = i + 1;
                    return false;
                }

                if (EX[i] == ')' && st.Count == 0 || EX[i] == ')' && Convert.ToChar(st.Peek()) != '(')
                {
                    EP = i + 1;
                    return false;
                }

                if (EX[i] == ')' && Convert.ToChar(st.Peek()) == '(')
                    st.Pop();
            }

            if (EX[EX.Length - 1] == ')' && st.Count != 0)
            {
                if (Convert.ToChar(st.Peek()) == '(')
                    st.Pop();
                else
                {
                    EP = EX.Length - 1;
                    return false;
                }
            }

            if (st.Count == 0)
            {
                return true;
            }
            else
            {
                EP = EX.IndexOf('(');
                return false;
            }
            return true;
        }

        static private bool IsOperator(char с)
        {
            if (("+-/*^()%".IndexOf(с) != -1))
                return true;
            return false;
        }
      
        public static string Redactor()
        {
            string red = "";
            string num = "";

            for (int i = 0; i < EX.Length; i++)
            {
                if (IsOperator(EX[i]))
                {
                    red += EX[i] + " ";
                    continue;
                }
                else
                {
                    while (!IsOperator(EX[i]))
                    {
                        num += EX[i]; 
                        i++;

                        if (i == EX.Length)
                            break; 
                    }
                    red += num + " ";
                    num = "";
                    i--;
                }
            }
            return red;
        }

        static private byte GetPriority(char s)
        {
            switch (s)
            {
                case '(': return 0;
                case ')': return 1;
                case '+': return 2;
                case '-': return 3;
                case '*': return 4;
                case '/': return 4;
                default: return 5;
            }
        }
        
        public static System.Collections.ArrayList StackCreate()
        {
            string red = Redactor();
            ArrayList list = new ArrayList();
            Stack stack = new Stack();
            if (red[0] == '&')
                throw new Exception();

            for (int i = 0; i < red.Length; i++)
            {
                int ind = red.IndexOf(' ');
                string tmp = red.Substring(0, ind);

                int num;
                bool suc = int.TryParse(tmp, out num);
                if (suc)
                {
                    list.Add(tmp);
                }
                else
                {

                    char op = Convert.ToChar(tmp);
                    if (IsOperator(op))
                    {
                        if (op == '(')
                            stack.Push(tmp);
                        else if (op == ')')
                        {
                            
                            char s = (char)stack.Pop();

                            while (s != '(')
                            {
                                list.Add(s.ToString());
                                s = Convert.ToChar(stack.Pop());
                            }
                        }
                        else 
                        {
                            if (stack.Count > 0)
                            {
                                char s1 = Convert.ToChar(stack.Peek());
                                
                                if (GetPriority(op) <= GetPriority(s1))
                                    list.Add(stack.Pop().ToString()); 
                            }
                            stack.Push(char.Parse(tmp)); 
                        }
                    }
                }
                red = red.Substring(ind + 1);
                i = 0;
            }
            while (stack.Count > 0)
                list.Add(stack.Pop());

            return list;
        }

       
        public static string StartEstaminate()
        {
            double res = 0; 
            Stack<double> tmp = new Stack<double>(); 
            ArrayList list = StackCreate();
            for (int i = 0; i < list.Count; i++)
            {
                string s = Convert.ToString(list[i]);
                double num;
                bool s1 = double.TryParse(s, out num);
                char c;
                bool s2 = char.TryParse(s, out c);

                if (s1)
                {
                    tmp.Push(num); 
                    continue;
                }
                else if (s2)
                {
                    if (IsOperator(c)) 

                    {  

                        long a = (long)tmp.Pop();
                        long b = (long)tmp.Pop();
                        try 
                        {
                            switch (c)
                            {
                                case '+':
                                    res = Calc.Sum(b, a);
                                    break;
                                case '-':
                                    res = Calc.Sub(b, a);
                                    break;
                                case '*':
                                    res = Calc.Mul(b, a);
                                    break;
                                case '/':
                                    res = Calc.Div(b, a);
                                    break;
                                case '%':
                                    res = Calc.Mod(b, a);
                                    break;
                            }
                            tmp.Push(res); 
                        }
                        catch (OverflowException ex)
                        {
                            throw ex;
                        }
                        catch (DivideByZeroException ex)
                        {
                            throw ex;
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }


                    }
                }
            }
            
            return tmp.Peek().ToString();
        }

        
        public static string GetRes()
        {

            string res = "";
            if (EX.Length > 65536)
                throw new Error07();
            bool b = CheckEx();

            if (b)
            {
                ArrayList list = StackCreate();
                res = StartEstaminate();
            }
            else
            {
                char p = EX[EP];
                switch (p)
                {
                    case '(':
                        throw new Error01();

                    case ')':
                        throw new Error01();

                    default:
                        throw new Error04($"Два послідовні оператори для символу {EP}");
                }
            }
            return res;
        }
    }
}
