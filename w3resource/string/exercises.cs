/*
5. Write a program in C# Sharp to count the total number of words in a string.
Test Data :
Input the string : This is w3resource.com
Expected Output :

Total number of words in the string is : 3 
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

        public static void SolveExercise4()
        {
            Console.Write("Input the phrase: ");
            string phrase = Console.ReadLine()!;
            
            Console.WriteLine("The characters of the string in reverse are: ");

            for (int i = phrase.Length - 1; i >= 0; i--)
                Console.Write(phrase[i] + " ");
        }

        public static void SolveExercise5()
        {
            string sentence = "This is w3resource.com";
            int len = sentence.Split(" ").Length;

            Console.WriteLine("The sentence '{0}' has {1} words.", sentence, len);
        }
    }
}
