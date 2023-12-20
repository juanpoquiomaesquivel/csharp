/*
6. Write a program in C# Sharp to create a function to swap two integer numbers.
Test Data :
Enter a number: 5
Enter another number: 6
Expected Output :
Now the 1st number is : 6 , and the 2nd number is : 5
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

        public static void SolveExercise6()
        {
            int fNum = 4;
            int sNum = 75;
            Console.WriteLine("First number is: {0} and Second number is: {1}", fNum, sNum);
            Console.WriteLine("After swap...");
            _exe6_Swap(ref fNum, ref sNum);
            Console.WriteLine("First number is: {0} and Second number is: {1}", fNum, sNum);
        }

        private static void _exe6_Swap(ref int n1, ref int n2)
        {
            int temp = n1;
            n1 = n2;
            n2 = temp;
        }
    }
}
