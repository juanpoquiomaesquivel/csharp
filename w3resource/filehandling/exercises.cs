/*
1. Write a program in C# Sharp to create a blank file on the disk.
Expected Output :

 A file created with name mytest.txt
*/
using System;

namespace Exercises
{
    class Solution
    {
        public static void SolveExercise1()
        {
            string fileName = @"mytest.txt";

            try
            {
                using (FileStream stream = File.Create(fileName))
                {
                    Console.WriteLine("A file named {0} has been created.", fileName);
                }
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
