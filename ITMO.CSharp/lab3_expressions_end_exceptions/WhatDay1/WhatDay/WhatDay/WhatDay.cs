using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Программа, которая считывает целое число, являющееся днем года (от 1 до 365) с экрана консоли 
и сохраняет его в целочисленной переменной. 
Далее программа преобразует это число в название и день месяца и выводит результат на консоль. 
Например, вводим числом 40, получаем результат “February 9”. 
(В данном упражнении не учитываются високосные годы.)
*/
namespace WhatDay
{
    class WhatDay
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Please enter a day number between 1 and 365: "); //
            string line = Console.ReadLine();
            int dayNum = int.Parse(line);

            int monthNum = 0;
            if (dayNum <= 31) //january
            {
                goto End;
            } else
            {
                dayNum -= 31;
                monthNum++;
            }
            if (dayNum <= 28) //fabruary
            {
                goto End;
            } else
            {
                dayNum -= 28;
                monthNum++;
            }
            if (dayNum <= 31) //march
            {
                goto End;
            } else
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
            string monthName;

            switch (monthNum)
            {
                case 0:
                    monthName = "January"; break;
                case 1:
                    monthName = "February"; break;
                case 2:
                    monthName = "March"; break;
                case 3:
                    monthName = "April"; break;
                case 4:
                    monthName = "May"; break;
                case 5:
                    monthName = "June"; break;
                case 6:
                    monthName = "July"; break;
                case 7:
                    monthName = "August"; break;
                case 8:
                    monthName = "September"; break;
                case 9:
                    monthName = "October"; break;
                case 10:
                    monthName = "November"; break;
                case 11:
                    monthName = "December"; break;
                default:
                    monthName = "Not done yet";
                break;
            }

            Console.WriteLine("{0} {1}", dayNum, monthName);

        }
    }
}
