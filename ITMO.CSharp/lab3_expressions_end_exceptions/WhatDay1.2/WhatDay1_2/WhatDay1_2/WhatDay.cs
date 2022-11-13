﻿using System;
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
//Замена 12 if-инструкций одним циклом foreach

namespace WhatDay1_2
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
            System.Console.Write("Please enter a day number between 1 and 365: ");
            string line = Console.ReadLine();
            int dayNum = int.Parse(line);

            int monthNum = 0;
            foreach (int daysInMonth in DaysInMonths)
            {
                if (dayNum <= daysInMonth)
                {
                    break;
                }
                else
                {
                    dayNum -= daysInMonth;
                    monthNum++;
                }
            }
            MonthName temp = (MonthName)monthNum;
            string monthName = temp.ToString();

            Console.WriteLine("{0} {1}", dayNum, monthName);
        }
        // Don't modify anything below here
        static System.Collections.ICollection DaysInMonths
            = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    }
}
