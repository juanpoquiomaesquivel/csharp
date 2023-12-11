/*
3. Write a C# Sharp program to create a blank file on the disk if the same file already exists.
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

        public static void SolveExercise3()
        {
            string fileName = @"mytest.txt";

            try
            {
                if (File.Exists(fileName))
                    File.Delete(fileName);

                using (FileStream fileStr = File.Create(fileName))
                    Console.WriteLine("A file was create with name {0}", fileName);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.ToString());
            }
        }
    }
}
