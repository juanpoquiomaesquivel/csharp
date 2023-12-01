/*
4. Write a C# Sharp program to read 10 numbers and find their average and sum.
Test Data :
Input the 10 numbers :
Number-1 :2
...
Number-10 :2
Expected Output :
The sum of 10 no is : 51
The Average is : 5.100000
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

        public static void SolveExercise4()
        {
            Console.WriteLine("Input 10 numbers");
            int[] numbers = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter the number {0}: ", i + 1);
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The sum is: {0}", numbers.Sum());
            Console.WriteLine("The average is: {0}", numbers.Average());
        }
    }
}
