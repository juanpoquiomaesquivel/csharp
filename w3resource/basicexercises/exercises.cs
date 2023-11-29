/*
6. Write a C# Sharp program to print the output of the multiplication of three numbers
entered by the user.
Test Data:
Input the first number to multiply: 2
Input the second number to multiply: 3
Input the third number to multiply: 6
Expected Output:
2 x 3 x 6 = 36
*/
using System;

namespace Exercises
{
    class Solution
    {
        public static void SolveExercise1()
        {
            var myName = "Juan";
            System.Console.WriteLine("Hello:\n" + myName);
        }

        public static void SolveExercise2()
        {
            int a = 45,
                b = -8,
                res = a + b;
            System.Console.WriteLine("sum: {0} + {1} = {2}", a, b, res);
        }

        public static void SolveExercise3()
        {
            double a = 11D,
                b = 2,
                res = a / b;
            System.Console.WriteLine("div: {0} / {1} = {2}", a, b, res);
        }

        public static void SolveExercise4()
        {
            System.Console.WriteLine($"{-1 + 4 * 6}");
            System.Console.WriteLine($"{(35 + 5) % 7}");
            System.Console.WriteLine($"{14 + -4 * 6 / 11}");
            System.Console.WriteLine($"{2 + 15 / 6 * 1 - 7 % 2}");
        }

        public static void SolveExercise5()
        {
            Console.Write("Input the First Number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Input the Second Number: ");
            int num2 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Before swapping");
            System.Console.WriteLine($"num1 = {num1}, num2 = {num2}");
            int aux = num1;
            num1 = num2;
            num2 = aux;
            System.Console.WriteLine("After swapping");
            System.Console.WriteLine($"num1 = {num1}, num2 = {num2}");
        }

        public static void SolveExercise6()
        {
            Console.Write("Input the first number to multiply: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the second number to multiply: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the third number to multiply: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            int res = num1 * num2 * num3;
            Console.WriteLine("{0} x {1} x {2} = {3}", num1, num2, num3, res);
        }
    }
}
