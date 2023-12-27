/*
9. Write a C# Sharp program to create a string with the last char added at the front
and back of a given string of length 1 or more.

Sample Input:
"Red"
"Green"
"1"
Expected Output:
dRedd
nGreenn
111
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
            System.Console.WriteLine("{0}", exe5_concat(str));
            str = "else";
            System.Console.WriteLine("{0}", exe5_concat(str));
        }

        private static string exe5_concat(string word)
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

        public static void SolveExercise7()
        {
            string[] words = { "abcd", "a", "xy" };

            foreach (var word in words)
                Console.WriteLine(word);

            Console.WriteLine("After...");

            foreach (var word in words)
                Console.WriteLine(exe7_Invert(word));
        }

        private static string exe7_Invert(string str)
        {
            var len = str.Length;

            return len > 1
                ? str.Substring(len - 1, 1) + str.Substring(1, len - 2) + str.Substring(0, 1)
                : str;
        }

        public static void SolveExercise8()
        {
            string[] words = { "C Sharp", "JS", "a" };

            foreach (var word in words)
                Console.WriteLine(word);

            Console.WriteLine("After...");

            foreach (var word in words)
                Console.WriteLine(exe8_Front(word));
        }

        private static string exe8_Front(string str)
        {
            var len = str.Length;

            return len >= 2
                ? str.Substring(0, 2)
                    + str.Substring(0, 2)
                    + str.Substring(0, 2)
                    + str.Substring(0, 2)
                : str;
        }

        public static void SolveExercise9()
        {
            string[] words = { "Red", "Green", "1" };

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine("\"{0}\"", words[i]);
                int len = words[i].Length;
                char c = words[i][len - 1];
                words[i] = c + words[i] + c;
            }

            foreach (var item in words)
                Console.WriteLine(item);
        }
    }
}
