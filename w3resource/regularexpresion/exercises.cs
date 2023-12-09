/*
3. Write a C# Sharp program to check whether a given string of characters can be transformed into a palindrome. Return true otherwise false.
Sample Data:
("amamd") -> True
("pamamd") -> False
("ferre") -> True
*/
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Exercises
{
    class Solution
    {
        public static void SolveExercise1()
        {
            string hc = "#CD5C5C";
            System.Console.WriteLine("(\"{0}\") -> {1}", hc, _exe1_regexHexColor(hc));
            hc = "#f08080";
            System.Console.WriteLine("(\"{0}\") -> {1}", hc, _exe1_regexHexColor(hc));
            hc = "#E9967A";
            System.Console.WriteLine("(\"{0}\") -> {1}", hc, _exe1_regexHexColor(hc));
            hc = "#EFFA07A";
            System.Console.WriteLine("(\"{0}\") -> {1}", hc, _exe1_regexHexColor(hc));
        }

        private static bool _exe1_regexHexColor(string hexColor)
        {
            return Regex.IsMatch(hexColor, @"[#][0-9A-Fa-f]{6}\b");
        }

        public static void SolveExercise2()
        {
            string text = "#CPP Exercises.";
            System.Console.WriteLine("(\"{0}\") -> {1}", text, _exe2_regexAverage(text));
            text = "C# syntax is highly expressive, yet it is also simple and easy to learn.";
            System.Console.WriteLine("(\"{0}\") -> {1}", text, _exe2_regexAverage(text));
            text = "C# is an elegant and type-safe object-oriented language";
            System.Console.WriteLine("(\"{0}\") -> {1}", text, _exe2_regexAverage(text));
        }

        private static double _exe2_regexAverage(string text)
        {
            string newText = Regex.Replace(text, "[^A-Za-z ]", "");
            double len = newText.Split(' ').Select(x => x.Length).Average();
            return Math.Round(len, 2);
        }

        public static void SolveExercise3()
        {
            string[] words = new string[] { "amamd", "pamamd", "ferre" };

            foreach (var word in words)
                Console.WriteLine(
                    $"Original string: {word}, can be transformed into a palindrome? {_exe3_regexPalindrome(word)}"
                );
        }

        private static bool _exe3_regexPalindrome(string word)
        {
            return Regex
                    .Replace(string.Concat(word.OrderBy(c => c)), @"([a-z])\1{1}", string.Empty)
                    .Length <= 1;
        }
    }
}
