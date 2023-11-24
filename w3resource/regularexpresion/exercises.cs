/*
2. Write a C# Sharp program to calculate the average word length in a given string.
Round the average length up to two decimal places.
Sample Data:
("CPP Exercises." -> 6
("C# syntax is highly expressive, yet it is also simple and easy to learn.") -> 4
(“C# is an elegant and type-safe object-oriented language") -> 5.62
*/
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
    }
}
