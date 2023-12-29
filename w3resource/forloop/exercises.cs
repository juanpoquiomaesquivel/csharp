/*
7. Write a program in C# Sharp to display the multiplication table vertically from 1 to n.
Test Data :
Input upto the table number starting from 1 : 8
Expected Output :
Multiplication table from 1 to 8
1x1 = 1, 2x1 = 2, 3x1 = 3, 4x1 = 4, 5x1 = 5, 6x1 = 6, 7x1 = 7, 8x1 = 8
...
1x10 = 10, 2x10 = 20, 3x10 = 30, 4x10 = 40, 5x10 = 50, 6x10 = 60, 7x10 = 70, 8x10 = 80
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
    }
}
