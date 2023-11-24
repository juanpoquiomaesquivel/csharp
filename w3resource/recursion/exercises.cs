/*
1. Write a program in C# Sharp to print the first n natural numbers using recursion.
Test Data :
How many numbers to print : 10
Expected Output :
1 2 3 4 5 6 7 8 9 10
*/
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
    }
}
