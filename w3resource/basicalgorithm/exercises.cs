/*
1. Write a C# Sharp program to compute the sum of the two numerical 
values. If the two values are the same, return triple their sum.

Sample Input:
1, 2
3, 2
2, 2
Expected Output:
3
5
12
*/
namespace Exercises
{
    class Solution
    {
        public static void SolveExercise1()
        {
            int n1 = 1, n2 = 2;
            System.Console.WriteLine($"n1: {n1}, n2: {n2} -> {exe1_sum(n1, n2)}");
            n1 = 3;
            n2 = 2;
            System.Console.WriteLine($"n1: {n1}, n2: {n2} -> {exe1_sum(n1, n2)}");
            n1 = 2;
            n2 = 2;
            System.Console.WriteLine($"n1: {n1}, n2: {n2} -> {exe1_sum(n1, n2)}");
        }

        private static int exe1_sum(int num1, int num2)
        {
            int sum = num1 + num2;

            return (num1 == num2 ? 3 * sum : sum);
        }
    }
}
