/*
6. Write a program in C# Sharp to display the multiplication table of a given integer.
Test Data :
Input the number (Table to be calculated) : 15
Expected Output :
15 X 1 = 15
...
...
15 X 10 = 150
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
    }
}
