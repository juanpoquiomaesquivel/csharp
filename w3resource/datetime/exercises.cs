/*
2. Write a C# Sharp program to display the Day properties (year, month, day,
hour, minute, second, millisecond etc.).

Expected Output :

year = 2016
month = 8
day = 16
hour = 3
minute = 57
second = 32
millisecond = 11
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
    }
}
