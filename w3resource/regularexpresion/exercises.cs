/*
4. Write a C# Sharp program to validate a password of length 7 to 16 characters with the following guidelines:
• Length between 7 and 16 characters.
• At least one lowercase letter (a-z).
• At least one uppercase letter (A-Z).
• At least one digit (0-9).
• Supported special characters: ! @ # $ % ^ & * ( ) + = _ - { } [ ] : ; " ' ? < > , .
Sample Data:
("Suuu$21g@") -> True
("W#1g@") -> False
("a&&g@") -> False
("sdsd723#$Amid") -> True
("sdsd723#$Amidkiouy") -> False
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

        public static void SolveExercise4()
        {
            string[] passwords = new string[]
            {
                "Suuu$21g@",
                "W#1g@",
                "a&&g@",
                "sdsd723#$Amid",
                "sdsd723#$Amidkiouy"
            };

            foreach (var pw in passwords)
                Console.WriteLine($"({pw}) -> {_exe4_regexValidate(pw)}");
        }

        private static bool _exe4_regexValidate(string password)
        {
            return password.Length >= 7
                && password.Length <= 16
                && Regex.IsMatch(password, "[A-Z]")
                && Regex.IsMatch(password, "[a-z]")
                && Regex.IsMatch(password, @"\d")
                && Regex.IsMatch(password, @"[!-/:-@\[-_{-~]")
                && !Regex.IsMatch(password, @"[^\dA-Za-z!-/:-@\[-_{-~]");
        }
    }
}
