/*
4. Write a C# Sharp program to find out whether a given year is a leap year or not.
Test Data : 2016
Expected Output :
2016 is a leap year.
*/
using System;

namespace Exercises
{
    class Solution
    {
        public static void SolveExercise1()
        {
            int x,
                y;
            System.Console.Write("Enter a first number: ");
            x = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("Enter a second number: ");
            y = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("{0} and {1} are {2}", x, y, x == y ? "equal." : "not equal.");
        }

        public static void SolveExercise2()
        {
            int num;
            System.Console.Write("Enter the number: ");
            num = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("{0} is an {1} integer", num, num % 2 == 0 ? "even" : "odd");
        }

        public static void SolveExercise3()
        {
            Console.Write("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The number is {0}.", num >= 0 ? "positive" : "negative");
        }

        public static void SolveExercise4()
        {
            Console.Write("Input the date: ");
            int year = int.Parse(Console.ReadLine()!);
            Console.WriteLine(
                "The year {0} {1} a leap year.",
                year,
                year % 4 == 0 ? "is" : "is not"
            );
        }
    }
}
