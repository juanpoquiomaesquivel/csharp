/*
4. Write a program in C# Sharp to display the individual digits of a given number using recursion.
Test Data :
Input any number : 1234
Expected Output :
The digits in the number 1234 are : 1 2 3 4
*/
using System;

namespace Exercises
{
    class Solution
    {
        public static void SolveExercise1()
        {
            System.Console.Write("How many numbers to print: ");
            int number = int.Parse(System.Console.ReadLine()!);
            _exe1_printNumber(number);
        }

        private static void _exe1_printNumber(int n)
        {
            if (n >= 1)
            {
                _exe1_printNumber(n - 1);
                System.Console.Write(n + " ");
            }
        }

        public static void SolveExercise2()
        {
            System.Console.Write("How many numbers to print: ");
            int number = Convert.ToInt32(System.Console.ReadLine()!);
            _exe2_printNumber(number);
        }

        private static void _exe2_printNumber(int n)
        {
            if (n >= 1)
            {
                System.Console.Write(n + " ");
                _exe2_printNumber(n - 1);
            }
        }

        public static void SolveExercise3()
        {
            Console.Write("How many numbers to sum: ");
            int n = int.Parse(Console.ReadLine()!);
            Console.WriteLine("The sum of first {0} natural numbers is: {1}", n, _exe3_sumN(n));
        }

        private static int _exe3_sumN(int N)
        {
            return N == 1 ? 1 : N + _exe3_sumN(N - 1);
        }

        public static void SolveExercise4()
        {
            Console.Write("Input any number: ");
            string number = Console.ReadLine()!;
            _exe4_digits(number);
        }

        private static void _exe4_digits(string number)
        {
            if (number.Length > 0)
            {
                Console.Write(number[0] + " ");
                _exe4_digits(number.Remove(0, 1));
            }
        }
    }
}
