/*
2. Write a program in C# Sharp to print numbers from n to 1 using recursion.
Test Data :
How many numbers to print : 10
Expected Output :
10 9 8 7 6 5 4 3 2 1
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
    }
}
