/*
1. Write a C# Sharp program to check whether a given string is a valid Hex code or not. Return true if this string is a valid code otherwise false.
Sample Data:
("#CD5C5C") -> True
("#f08080") -> True
("#E9967A") -> True
("#EFFA07A") -> False
*/
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
    }
}
