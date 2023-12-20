/*
5. Write a program in C# Sharp to calculate the sum of elements in an array.
Test Data :
Input 5 elements in the array :
element - 0 : 5
element - 1 : 7
element - 2 : 3
element - 3 : 2
element - 4 : 9
Expected Output :
The sum of the elements of the array is 26
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
            Console.WriteLine(
                "{0} contains {1} white spaces.",
                value,
                _exe4_CountWhiteSpaces(value)
            );
        }

        private static int _exe4_CountWhiteSpaces(string str)
        {
            return str.Count(s => s == ' ');
        }

        public static void SolveExercise5()
        {
            int[] array = { 5, 7, 3, 2, 9 };
            Console.WriteLine("The sum of the array is: " + _exe5_SumElements(array));
        }

        private static int _exe5_SumElements(int[] array)
        {
            return array.Sum();
        }
    }
}
