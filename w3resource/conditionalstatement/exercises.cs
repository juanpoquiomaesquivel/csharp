/*
6. Write a C# Sharp program to read the value of an integer m and display the value of n is
1 when m is larger than 0, 0 when m is 0 and -1 when m is less than 0.
Test Data : -5
Expected Output:
The value of n = -1
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

        public static void SolveExercise5()
        {
            Console.Write("Enter the age of the candidate: ");
            int age = Convert.ToInt32(Console.ReadLine());
            bool isEligible = age >= 18;

            if (isEligible)
                Console.WriteLine("Congratulations! you are eligible for casting your vote.");
            else
                Console.WriteLine(
                    "Sorry! you are not eligible for this election, you're underage."
                );
        }

        public static void SolveExercise6()
        {
            Console.Write("Enter the 'm' value: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int n = -1;

            if (m > 0)
                n = 1;
            else if (m == 0)
                n = 0;

            Console.WriteLine("The value of 'n' is {0}.", n);
        }
    }
}
