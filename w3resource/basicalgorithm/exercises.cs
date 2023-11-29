/*
6. Write a C# Sharp program to remove the character at a given position in the
string. The given position will be in the range 0..(string length -1) inclusive.

Sample Input:
"Python", 1
"Python", o
"Python", 4
Expected Output:
Pthon
ython
Pythn
*/
using System;

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

        public static void SolveExercise4()
        {
            int num = 103;
            System.Console.WriteLine($"num: {num} -> {exe4_verify(num)}");
            num = 90;
            System.Console.WriteLine($"num: {num} -> {exe4_verify(num)}");
            num = 89;
            System.Console.WriteLine($"num: {num} -> {exe4_verify(num)}");
        }

        private static bool exe4_verify(int x)
        {
            return Math.Abs(x - 100) <= 10 || Math.Abs(x - 200) <= 10;
        }

        public static void SolveExercise5()
        {
            string str = "if else";
            System.Console.WriteLine("{0}", exe4_concat(str));
            str = "else";
            System.Console.WriteLine("{0}", exe4_concat(str));
        }

        private static string exe4_concat(string word)
        {
            string aux = (word.Length <= 2 ? word : word.Substring(0, 2));

            return (aux.Equals("if") ? word : "if " + word);
        }

        public static void SolveExercise6()
        {
            string word = "Python";
            Console.WriteLine(word.Remove(1, 1));
            Console.WriteLine(word.Remove(0, 1));
            Console.WriteLine(word.Remove(4, 1));
        }
    }
}
