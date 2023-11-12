/*
5. Write a C# Sharp program to swap two numbers.
Test Data:
Input the First Number : 5
Input the Second Number : 6
Expected Output:
After Swapping :
First Number : 6
Second Number : 5
*/
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
            int a = 45, b = -8, res = a + b;
            System.Console.WriteLine("sum: {0} + {1} = {2}", a, b, res);
        }

        public static void SolveExercise3()
        {
            double a = 11D, b = 2, res = a / b;
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
    }
}
