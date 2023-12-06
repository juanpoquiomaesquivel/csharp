/*
4. Write a program in C# Sharp to print individual characters of the string in reverse order.
Test Data :
Input the string : w3resource.com
Expected Output :

The characters of the string in reverse are : 

m  o  c  .  e  c  r  u  o  s  e  r  3  w 
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
    }
}
