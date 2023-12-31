/*
10. Write a C# Sharp program that takes three numbers (x,y,z) as input and outputs (x+y).z and x.y + y.z.
Test Data:
Enter first number - 5
Enter second number - 6
Enter third number - 7

Expected Output:
Result of specified numbers 5, 6 and 7, (x+y).z is 77 and x.y + y.z is 72
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
            int num1 = int.Parse(Console.ReadLine()!);
            Console.Write("Input the Second Number: ");
            int num2 = int.Parse(Console.ReadLine()!);
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

        public static void SolveExercise7()
        {
            Console.Write("Input the first number: ");
            int n1 = int.Parse(Console.ReadLine()!);

            Console.Write("Input the second number: ");
            int n2 = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"{n1} + {n2} = {n1 + n2}");
            Console.WriteLine($"{n1} - {n2} = {n1 - n2}");
            Console.WriteLine($"{n1} * {n2} = {n1 * n2}");
            Console.WriteLine($"{n1} / {n2} = {n1 / n2}");
            Console.WriteLine($"{n1} mod {n2} = {n1 % n2}");
        }

        public static void SolveExercise8()
        {
            Console.Write("Input the number: ");
            int mm = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
                Console.WriteLine("{0} * {1} = {2}", mm, i, mm * i);
        }

        public static void SolveExercise9()
        {
            int[] nums = new int[4];

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("Enter the number {0}: ", i + 1);
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(
                "The average of {0}, {1}, {2} and {3} is {4}",
                nums[0],
                nums[1],
                nums[2],
                nums[3],
                nums.Average()
            );
        }

        public static void SolveExercise10()
        {
            double x,
                y,
                z;
            Console.Write("Enter the first number: ");
            x = int.Parse(Console.ReadLine()!);
            Console.Write("Enter the second number: ");
            y = int.Parse(Console.ReadLine()!);
            Console.Write("Enter the thrid number: ");
            z = int.Parse(Console.ReadLine()!);

            Console.WriteLine(
                $"The result of specified numbers {x}, {y} and {z}, (x+y).z = {(x + y) * z} and x.y + y.z = {x * y + y * z}"
            );
        }
    }
}
