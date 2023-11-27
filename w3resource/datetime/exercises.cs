/*
1. Write a C# Sharp program to extract the Date property and display the DateTime
value in the formatted output.

Expected Output:

Complete date: 6/8/2016 11:49:00 AM
Short Date: 6/8/2016
Display date using 24-hour clock format:
6/8/2016 12:00 AM
06/08/2016 00:00
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
    }
}
