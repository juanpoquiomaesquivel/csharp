/*
2. Write a C# Sharp program to get the absolute difference between n and 51. 
If n is broader than 51 return triple the absolute difference.

Sample Input:
53
30
51
Expected Output:
6
21
0
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

        public static void SolveExercise2()
        {
            int n = 53;
            System.Console.WriteLine($"n: {n} -> {exe2_abs(n)}");
            n = 30;
            System.Console.WriteLine($"n: {n} -> {exe2_abs(n)}");
            n = 51;
            System.Console.WriteLine($"n: {n} -> {exe2_abs(n)}");
        }

        private static int exe2_abs(int N)
        {
            int abs = N - 51;

            return (N > 51 ? 3 * abs : -abs);
        }
    }
}
