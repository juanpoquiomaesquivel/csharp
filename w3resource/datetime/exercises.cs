/*
4. Write a C# Sharp program to display the number of days of the year between two specified years.

Expected Output :

12/31/2001: day 365 of 2001
12/31/2002: day 365 of 2002
12/31/2003: day 365 of 2003
12/31/2004: day 366 of 2004 (Leap Year)
12/31/2005: day 365 of 2005
12/31/2006: day 365 of 2006
12/31/2007: day 365 of 2007
12/31/2008: day 366 of 2008 (Leap Year)
*/
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
    }
}
