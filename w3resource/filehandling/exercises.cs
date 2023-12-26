/*
5. Write a C# Sharp program to create a text file and read it.
Expected Output :

 Here is the content of the file mytest.txt :
 Hello and Welcome
 It is the first content
 of the text file mytest.txt
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

                using (StreamWriter fileStr = File.CreateText(fileName))
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

        public static void SolveExercise5()
        {
            string fileName = @"mytest.txt";

            try
            {
                if (File.Exists(fileName))
                    File.Delete(fileName);

                Console.Write("\n\nCreate a file with text and read the file:\n");
                Console.Write("-------------------------------------------------\n");

                using (StreamWriter fileStr = File.CreateText(fileName))
                {
                    fileStr.WriteLine("Hello and Welcome");
                    fileStr.WriteLine("It is the first content");
                    fileStr.WriteLine("of the text file mytest.txt");
                }

                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    Console.WriteLine("Here is the content of the file mytest.txt : ");

                    while ((s = sr!.ReadLine()) != null)
                        Console.WriteLine(s);

                    Console.WriteLine("");
                }
            }
            catch (Exception MyExcep)
            {
                Console.WriteLine(MyExcep.ToString());
            }
        }
    }
}
