/*
8. Write a C# Sharp program to find the largest of three numbers.
Test Data :
Input the 1st number :25
Input the 2nd number :63
Input the 3rd number :10
Expected Output :
The 2nd Number is the greatest among three
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

        public static void SolveExercise7()
        {
            Console.Write("Enter your height in centimeters: ");
            int height = Convert.ToInt32(Console.ReadLine());

            if (height > 160)
                Console.WriteLine("The person is tall.");
            else if (height <= 160 && height >= 150)
                Console.WriteLine("The person is average.");
            else
                Console.WriteLine("The person is dwarf.");
        }

        public static void SolveExercise8()
        {
            int n1 = 16,
                n2 = 29,
                n3 = 3;

            if (n1 >= n2 && n1 >= n3)
                Console.WriteLine("The largest number is {0}", n1);
            else if (n2 >= n1 && n2 >= n3)
                Console.WriteLine("The largest number is {0}", n2);
            else if (n3 >= n1 && n3 >= n2)
                Console.WriteLine("The largest number is {0}", n3);
        }
    }
}
