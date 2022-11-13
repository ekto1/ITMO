using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
/*
Использование в методах параметров, передаваемых по ссылке
Cоздадание метода Swap, который поменяет местами значения параметров. 
При этом вы будете использовать параметры, передаваемые по ссылке.
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
        class Test
        {
            public static void Main(string[] args)
            {
                int x, y;

                Console.WriteLine("Enter first number: ");
                x = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter second number: ");
                y = int.Parse(Console.ReadLine());

                /*
                //this is the test harness
                int greater;
                greater = Utils.Greater(x, y);
                Console.WriteLine("The greater value is " + greater);
                */

                //Test Swap method
                Console.WriteLine("Before swap: " + x + ", " + y);
                Utils.Swap(ref x, ref y);
                Console.WriteLine("After swap: " + x + ", " + y);
            }
        }
        
    }
}
