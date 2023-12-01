/*
3. Write a C# Sharp program that displays the sum of n natural numbers.
Test Data : 7
Expected Output :
The first 7 natural number is :
1 2 3 4 5 6 7
The Sum of Natural Number upto 7 terms : 28
*/
using System;

namespace Exercises
{
    class Solution
    {
        public static void SolveExercise1()
        {
            for (var i = 1; i <= 10; i++)
                System.Console.Write(i + " ");
        }

        public static void SolveExercise2()
        {
            System.Console.WriteLine("The first 10 natural numbers are:");
            int sum = 0;

            for (int i = 1; i <= 10; i++)
            {
                System.Console.Write(i + " ");
                sum += i;
            }

            System.Console.WriteLine("\nThe sum is: {0}", sum);
        }

        public static void SolveExercise3()
        {
            Console.Write("Enter the 'n' number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n; i++)
                sum += i;

            Console.WriteLine("The sum of natural numbers up to {0} terms is: {1}", n, sum);
        }
    }
}
