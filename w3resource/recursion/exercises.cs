/*
6. Write a program in C to print even or odd numbers in a given range using recursion.
Test Data :
Input the range to print starting from 1 : 20
Expected Output :
All even numbers from 1 to 20 are :
2 4 6 8 10 12 14 16 18 20

All odd numbers from 1 to 20 are :
1 3 5 7 9 11 13 15 17 19
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

        public static void SolveExercise5()
        {
            Console.Write("Input the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(
                "The number {0} contains {1} number of digits.",
                number,
                _exe5_CountDigits(number)
            );
        }

        private static int _exe5_CountDigits(int number)
        {
            if (number == 0)
                return 0;

            return _exe5_CountDigits(number / 10) + 1;
        }

        public static void SolveExercise6()
        {
            Console.Write("Input the range to print starting from: ");
            int init = Convert.ToInt32(Console.ReadLine());
            Console.Write("To: ");
            int last = Convert.ToInt32(Console.ReadLine());

            _exe6_PrintEvenNumbers(init, last, "even");
            _exe6_PrintEvenNumbers(init, last, "odd");
        }

        private static void _exe6_PrintEvenNumbers(int init, int last, string numType)
        {
            if (numType == "even")
            {
                if (init % 2 == 0)
                    Console.Write(init + " ");
            }
            else if (init % 2 != 0) // default
                Console.Write(init + " ");

            if (init >= last)
            {
                Console.WriteLine();
                return;
            }

            _exe6_PrintEvenNumbers(init + 1, last, numType);
        }
    }
}
