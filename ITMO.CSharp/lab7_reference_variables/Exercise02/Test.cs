using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utils
{
    internal class Test
    {
        public static void Main()
        {
            Console.Write("Введите число, которое будет реверсировано: ");
            string s = Console.ReadLine();
            Utils.Reverse(ref s);
            Console.WriteLine(s);
        }
    }
}
