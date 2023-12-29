/*
8. Write a C# Sharp program to display the n terms of odd natural numbers and their sums.
Test Data
Input number of terms : 10
Expected Output :
The odd numbers are :1 3 5 7 9 11 13 15 17 19
The Sum of odd Natural Number upto 10 terms : 100
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

        public static void SolveExercise5()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            foreach (var number in numbers)
                Console.WriteLine(
                    "The cube of the number {0} is {1}.",
                    number,
                    Math.Pow(number, 3)
                );
        }

        public static void SolveExercise6()
        {
            Console.Write("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
                Console.WriteLine("{0} x {1} = {2}", num, i, num * i);
        }

        public static void SolveExercise7()
        {
            Console.Write("Enter the value of 'n': ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            for (int j = 0; j <= 10; j++)
                Console.WriteLine("{0} x {1} = {2}", i, j, i * j);
        }

        public static void SolveExercise8()
        {
            Console.Write("Enter the number of terms: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0,
                count = 0;

            Console.Write("Odd numbers: ");
            for (int i = 1; count < num; i += 2)
            {
                Console.Write("{0} ", i);
                count++;
                sum += i;
            }

            Console.WriteLine("\nThe sum is: " + sum);
        }
    }
}
