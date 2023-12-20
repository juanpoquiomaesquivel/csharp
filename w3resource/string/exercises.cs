/*
6. Write a program in C# Sharp to compare two strings without using a string library functions.
Test Data :
Input the 1st string : This is first string
Input the 2nd string : This is first string
Expected Output :

The length of both strings are equal and
also, both strings are equal.
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

        public static void SolveExercise6()
        {
            string word1,
                word2;
            word1 = "This is the first string";
            word2 = "This is the first striwg";
            bool flag = false;

            if (word1.Length == word2.Length)
            {
                Console.WriteLine("Both words have the same length.");
                flag = true;

                for (int i = 0; i < word1.Length && flag; i++)
                {
                    if (word1[i] != word2[i])
                        flag = false;
                }
            }
            else
                Console.WriteLine("The words do not have the same length.");

            Console.WriteLine(flag ? "The words are the same." : "The words are not equal.");
        }
    }
}
