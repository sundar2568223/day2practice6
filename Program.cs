﻿using System;
namespace Consoleday2prac4
{
    internal class program
    {
        static void Main(string[] args)
        {
            DateTime matchDate = new DateTime(day: 13, month: 07, year: 2023);

            DateTime currentDate = DateTime.Now;

            TimeSpan ts = matchDate.Subtract(currentDate);

            Console.WriteLine("Days Remain " + ts.Days);

            Console.WriteLine("Days Remain " + ts.Hours);

            Console.WriteLine(ts.ToString());

            Console.ReadKey();
        }
    }
}