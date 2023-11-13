/*
3. Write a C# Sharp program to check two given integers, and return true if
one of them is 30 or if their sum is 30.

Sample Input:
30, 0
25, 5
20, 30
20, 25
Expected Output:
True
True
True
False
*/
namespace Exercises
{
    class Solution
    {
        public static void SolveExercise1()
        {
            int n1 = 1,
                n2 = 2;
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

        public static void SolveExercise3()
        {
            int a = 30,
                b = 0;
            System.Console.WriteLine($"a: {a}, b: {b} -> {exe3_verify(a, b)}");
            a = 25;
            b = 5;
            System.Console.WriteLine($"a: {a}, b: {b} -> {exe3_verify(a, b)}");
            a = 20;
            b = 30;
            System.Console.WriteLine($"a: {a}, b: {b} -> {exe3_verify(a, b)}");
            a = 20;
            b = 25;
            System.Console.WriteLine($"a: {a}, b: {b} -> {exe3_verify(a, b)}");
        }

        private static bool exe3_verify(int num1, int num2)
        {
            return (num1 == 30 || num2 == 30) || (num1 + num2 == 30);
        }
    }
}
