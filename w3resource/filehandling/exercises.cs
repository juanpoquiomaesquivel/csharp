/*
4. Write a program in C# Sharp to create a file and add some text.
Expected Output:

 A file created with content name mytest.txt 
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

        public static void SolveExercise4()
        {
            string fileName = @"mytest.txt";

            try
            {
                if (File.Exists(fileName))
                    File.Delete(fileName);

                using (StreamWriter  fileStr = File.CreateText(fileName))
                {
                    fileStr.WriteLine(" Hello and Welcome");
                    fileStr.WriteLine(" It is the first content");
                    fileStr.WriteLine(" of the text file mytest.txt");
                    Console.WriteLine("A file created with content name {0}", fileName);
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.ToString());
            }
        }
    }
}
