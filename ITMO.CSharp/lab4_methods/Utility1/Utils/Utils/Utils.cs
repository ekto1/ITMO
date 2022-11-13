using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Cоздание класса Utils, в котором определите метод Greater. 
Этот метод будет принимать два целочисленных параметра и возвращать больший из них.
Для тестирования работы данного класса Вы создадите еще один класс (класс Test), 
в котором у пользователя будут запрашиваться два числа, далее будет вызываться метод Utils.Greater, 
после чего на экран консоли будет выводиться результат
 */
namespace Utils
{
    class Utils
    {
        public static int Greater (int a, int b)
        {
            if (a>b)
                return a;
            else
                return b;
        }
//this is the test harness
    class Test
    {
        public static void Main(string[] args)
        {
                int x, y;
                int greater;

                Console.WriteLine("Enter first number: ");
                x = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter second number: ");
                y = int.Parse(Console.ReadLine());

                greater = Utils.Greater(x, y);
                Console.WriteLine("The greater value is "+ greater);
        }
    }
        
    }
}
