/*
5. Write a C# Sharp program to get a DateTime value that represents the current date and time on the local computer.

Expected Output :

English (Ireland):
   Local date and time: 20/08/2016 15:49:03, Local
   UTC date and time: 20/08/2016 10:19:03, Utc
                                                                        
English (South Africa):
   Local date and time: 2016-08-20 03:49:03 PM, Local
   UTC date and time: 2016-08-20 10:19:03 AM, Utc
                                                                        
......
*/
using System;
using System.Globalization;

namespace Exercises
{
    class Solution
    {
        public static void SolveExercise1()
        {
            DateTime dt = new DateTime(2023, 11, 27, 4, 33, 0);
            System.Console.WriteLine($"Complete date: {dt.ToString()}");
            System.Console.WriteLine($"Short date: {dt.Date}");
            System.Console.WriteLine("Display date using 24-hour clock format:");
            System.Console.WriteLine($"{dt.Date.ToString("g")}");
            System.Console.WriteLine($"{dt.Date.ToString("dd/MMMM/yyyy HH:mm")}");
        }

        public static void SolveExercise2()
        {
            DateTime dt = new DateTime(2018, 11, 13, 14, 23, 10, 22);
            System.Console.WriteLine($"year: {dt.Year}");
            System.Console.WriteLine($"month: {dt.Month}");
            System.Console.WriteLine($"day: {dt.Day}");
            System.Console.WriteLine($"hour: {dt.Hour}");
            System.Console.WriteLine($"minute: {dt.Minute}");
            System.Console.WriteLine($"seconds: {dt.Second}");
            System.Console.WriteLine($"millisecond: {dt.Millisecond}");
        }

        public static void SolveExercise3()
        {
            DateTime dt = new DateTime(2016, 7, 11);
            Console.WriteLine($"The day of the week for {dt:d} is {dt.DayOfWeek}.");
        }

        public static void SolveExercise4()
        {
            DateTime dec31 = new DateTime(2000, 12, 31);

            for (int ctr = 0; ctr <= 20; ctr++)
            {
                DateTime display = dec31.AddYears(ctr);
                Console.WriteLine(
                    "{0:d}: day {1} of {2} {3}",
                    display,
                    display.DayOfYear,
                    display.Year,
                    DateTime.IsLeapYear(display.Year) ? "(Leap Year)" : ""
                );
            }
        }

        public static void SolveExercise5()
        {
            DateTime localDate = DateTime.Now;
            DateTime utcDate = DateTime.UtcNow;
            string[] cultureNames = { "en-IE", "en-ZA", "fr-CA", "de-CH", "ro-RO" };

            foreach (var cultureName in cultureNames)
            {
                var culture = new CultureInfo(cultureName);
                Console.WriteLine("{0}:", culture.NativeName);
                Console.WriteLine(
                    "   Local date and time: {0}, {1:G}",
                    localDate.ToString(culture),
                    localDate.Kind
                );
                Console.WriteLine(
                    "   UTC date and time: {0}, {1:G}\n",
                    utcDate.ToString(culture),
                    utcDate.Kind
                );
            }
        }
    }
}
