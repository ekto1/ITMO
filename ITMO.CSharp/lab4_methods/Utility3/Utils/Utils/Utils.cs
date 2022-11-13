using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Использование возвращаемых параметров в методах
Создадание метода Factorial, принимающий целое значение и рассчитывающий его факториал следующим образом:
Factorial(0)=1
Factorial(1)=1
Factorial(2)=1*2=2
Factorial(3)=1*2*3=6
Factorial(4)=1*2*3*4=24
 */
namespace Utils
{
    class Utils
    {
        public static int Greater(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public static bool Factorial(int n, out int answer)
        {
            int k; //loop counter
            int f; //working value
            bool ok = true; //true if ok, fasle if not
            //chek input value
            if (n < 0)
                ok = false;
            //calculate the factorial value as the product 
            //of all of the numbers from 2 to n
            try
            {
                checked
                {
                    f = 1;
                    for (k = 2; k <= n; ++k)
                    {
                        f = f * k;
                    }
                }
            }
            catch (Exception)
            {
                //if something goes wrong in the calculation catch it here
                //all exceptions are handeled the same way
                //set the result to zero and turn false
                f = 0;
                ok = false;
            }
            //assign result value
            answer = f;
            //return to caller
            return ok;
        }
        class Test
        {
            public static void Main(string[] args)
            {
                /*
                int x, y;

                Console.WriteLine("Enter first number: ");
                x = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter second number: ");
                y = int.Parse(Console.ReadLine());
                */
                /*
                //this is the test harness
                int greater;
                greater = Utils.Greater(x, y);
                Console.WriteLine("The greater value is " + greater);
                */
                /*
                //Test Swap method
                Console.WriteLine("Before swap: " + x + ", " + y);
                Utils.Swap(ref x, ref y);
                Console.WriteLine("After swap: " + x + ", " + y);
                */

                int f; //factorial result
                bool ok; //factorial success value

                //get input for factorial
                Console.WriteLine("Number for factorial: ");
                int x = int.Parse(Console.ReadLine());

                //test the factorial
                ok = Utils.Factorial(x, out f);
                //output factorial results
                if (ok)
                    Console.WriteLine("Factorial(" + x + ") = " + f);
                else
                    Console.WriteLine("Cannot compute this factorial");

            }
        }
    }
}
