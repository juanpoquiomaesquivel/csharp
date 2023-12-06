/*
4. Write a program in C# Sharp to create a function to input a string and count the number of spaces within the string.
Test Data :
Please input a string : This is a test string.
Expected Output :
"This is a test string." contains 4 spaces
*/
using System;

namespace Exercises
{
    class Solution
    {
        public static void SolveExercise1()
        {
            System.Console.WriteLine("THIS IS AN EXAMPLE OF AN USER DEFINED FUNCTION!");
            _exe1_Welcome();
        }

        private static void _exe1_Welcome()
        {
            System.Console.WriteLine("Welcome To This World!");
        }

        public static void SolveExercise2()
        {
            System.Console.Write("Tell me your name: ");
            string? yourName = System.Console.ReadLine();
            _exe2_WelcomeTo(yourName);
        }

        private static void _exe2_WelcomeTo(string? yourName)
        {
            System.Console.WriteLine("Welcome To This World! {0}", yourName);
        }

        public static void SolveExercise3()
        {
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The sum of {num1} and {num2} is {_exe3_Sum(num1, num2)}");
        }

        private static int _exe3_Sum(int n1, int n2)
        {
            return n1 + n2;
        }

        public static void SolveExercise4()
        {
            Console.Write("Please input a string: ");
            string value = Console.ReadLine()!;
            Console.WriteLine("{0} contains {1} white spaces.", value, _exe4_CountWhiteSpaces(value));
        }

        private static int _exe4_CountWhiteSpaces(string str)
        {
            return str.Count(s => s == ' ');
        }
    }
}
