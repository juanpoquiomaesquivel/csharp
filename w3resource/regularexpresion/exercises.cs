/*
6. Write a C# Sharp program to check for repeated occurrences of words in a given string.
Sample Data:
("C# C# syntax is highly expressive, yet it is is also simple and easy to to learn learn.") -> 3 matches found
("Red Green Green Black Black Green.") -> 2 matches found
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

        public static void SolveExercise5()
        {
            string txt1 = "AACC",
                txt2 = "PPRR";

            Console.WriteLine($"Original strings: '{txt1}' and '{txt2}'");

            if (txt1.Length == txt2.Length)
                Console.WriteLine(
                    "Check said two strings contain the same character pattern: "
                        + _exe5_SamePattern(txt1, txt2)
                );

            txt1 = "FFGG";
            txt2 = "ADAD";

            Console.WriteLine($"Original strings: '{txt1}' and '{txt2}'");

            if (txt1.Length == txt2.Length)
                Console.WriteLine(
                    "Check said two strings contain the same character pattern: "
                        + _exe5_SamePattern(txt1, txt2)
                );
        }

        private static bool _exe5_SamePattern(string text1, string text2)
        {
            for (int i = 0; i < text1.Length; i++)
                if (
                    text1.IndexOf(text1.Substring(i, 1), i + 1)
                    != text2.IndexOf(text2.Substring(i, 1), i + 1)
                )
                    return false;

            return true;
        }

        public static void SolveExercise6()
        {
            Regex rx = new Regex(
                @"\b(?<word>\w+)\s+(\k<word>)\b",
                RegexOptions.Compiled | RegexOptions.IgnoreCase
            );

            string text =
                "C# C# syntax is highly expressive, yet it is is also simple and easy to to learn learn.";
            //string text = "Red Green Green Black Black Green.";
            Console.WriteLine("Original string: \n" + text);

            MatchCollection matches = rx.Matches(text);

            Console.WriteLine("{0} matches found in the said string:\n   ", matches.Count);

            foreach (Match match in matches)
            {
                GroupCollection groups = match.Groups;
                Console.WriteLine(
                    "'{0}' repeated at positions {1} and {2}",
                    groups["word"].Value,
                    groups[0].Index,
                    groups[1].Index
                );
            }
        }
    }
}
