/*
2. Write a program in C# Sharp to remove a file from the disk.
Expected Output :
 Remove a file from the disk (at first create the file ) :
--------------------------------------------------------------
 The file mytest.txt deleted successfully.
 
  Remove a file from the disk (at first create the file ) :
--------------------------------------------------------------
 File does not exist
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

        public static void SolveExercise2()
        {
            string fileName = @"mytest.txt";

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
                Console.WriteLine("The file {0} has been deleted successfully.", fileName);
            }
            else
            {
                Console.Write("The file does not exist. [PRESS TO CONTINUE]");
                Console.ReadKey();
            }
        }
    }
}
