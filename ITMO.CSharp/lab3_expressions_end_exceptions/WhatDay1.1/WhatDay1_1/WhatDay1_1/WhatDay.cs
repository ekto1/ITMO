using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Программа, которая считывает целое число, являющееся днем года (от 1 до 365) 
с экрана консоли и сохраняет его в целочисленной переменной. 
Далее программа преобразует это число в название и день месяца и выводит результат на консоль. 
Например, вводим числом 40, получаем результат “February 9”. 
(В данном упражнении не учитываются високосные годы.)
 */
//Рассчитайть название месяца, используя перечисление

namespace WhatDay1_1
{
    enum MonthName
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
    class WhatDay
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Please enter a day number between 1 and 365: "); //
            string line = Console.ReadLine();
            int dayNum = int.Parse(line);

            int monthNum = 0;
            //12 if statements, as above
            if (dayNum <= 31) //january
            {
                goto End;
            }
            else
            {
                dayNum -= 31;
                monthNum++;
            }
            if (dayNum <= 28) //fabruary
            {
                goto End;
            }
            else
            {
                dayNum -= 28;
                monthNum++;
            }
            if (dayNum <= 31) //march
            {
                goto End;
            }
            else
            {
                dayNum -= 31;
                monthNum++;
            }
            if (dayNum <= 30) //april
            {
                goto End;
            }
            else
            {
                dayNum -= 30;
                monthNum++;
            }
            if (dayNum <= 31) //may
            {
                goto End;
            }
            else
            {
                dayNum -= 31;
                monthNum++;
            }
            if (dayNum <= 30)//june
            {
                goto End;
            }
            else
            {
                dayNum -= 30;
                monthNum++;
            }
            if (dayNum <= 31)//julay
            {
                goto End;
            }
            else
            {
                dayNum -= 31;
                monthNum++;
            }
            if (dayNum <= 31)//august
            {
                goto End;
            }
            else
            {
                dayNum -= 31;
                monthNum++;
            }
            if (dayNum <= 30)//september
            {
                goto End;
            }
            else
            {
                dayNum -= 30;
                monthNum++;
            }
            if (dayNum <= 31)//october
            {
                goto End;
            }
            else
            {
                dayNum -= 31;
                monthNum++;
            }
            if (dayNum <= 30)//november
            {
                goto End;
            }
            else
            {
                dayNum -= 30;
                monthNum++;
            }
            if (dayNum <= 31)//december
            {
                goto End;
            }
            else
            {
                dayNum -= 31;
                monthNum++;
            }
        End:
            MonthName temp = (MonthName)monthNum;

            string monthName = temp.ToString();

            Console.WriteLine("{0} {1}", dayNum, monthName);
        }
    }
}
