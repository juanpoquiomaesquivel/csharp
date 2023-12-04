/*
3. Write a C# Sharp program to separate individual characters from a string.
Test Data :
Input the string : w3resource.com
Expected Output :

The characters of the string are :
w  3  r  e  s  o  u  r  c  e  .  c  o  m
*/
using System;

namespace Exercises
{
    class Solution
    {
        public static void SolveExercise1()
        {
            System.Console.Write("Input the string: ");
            string line = System.Console.ReadLine()!;
            System.Console.WriteLine($"The string you entered is: {line}");
        }

        public static void SolveExercise2()
        {
            System.Console.Write("Input the string: ");
            string line = System.Console.ReadLine()!;
            int i = 0;

            foreach (char c in line)
                i++;

            System.Console.WriteLine("Length of the string: {0}", i);
        }

        public static void SolveExercise3()
        {
            Console.Write("Input the prhase: ");
            string phrase = Console.ReadLine()!;

            Console.WriteLine("The characters of the string are: ");

            foreach (char c in phrase)
                Console.Write(c + " ");
        }
    }
}
