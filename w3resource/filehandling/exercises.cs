/*
6. Write a program in C# Sharp to create a file and write an array of strings to the file.
Test Data :
Input number of lines to write in the file :2
Input 2 strings below :
Input line 1 : this is 1st line
Input line 2 : this is 2nd line
Expected Output :

 The content of the file is  :
----------------------------------
 this is 1st line
 this is 2nd line
*/
using System;
using System.IO;

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

        public static void SolveExercise6()
        {
            string fileName = @"mytest.txt";
            string[] arrLines;
            int n,
                i;

            Console.Write("\n\nCreate a file and write an array of strings:\n");
            Console.Write("---------------------------------------------------\n");

            if (File.Exists(fileName))
                File.Delete(fileName);

            Console.Write("Input number of lines to write in the file: ");
            n = Convert.ToInt32(Console.ReadLine());
            arrLines = new string[n];
            Console.Write("Input {0} strings below...\n", n);

            for (i = 0; i < n; i++)
            {
                Console.Write("Input line {0} : ", i + 1);
                arrLines[i] = Console.ReadLine();
            }

            System.IO.File.WriteAllLines(fileName, arrLines);

            using (StreamReader sr = File.OpenText(fileName))
            {
                string s = "";
                Console.Write("\nThe content of the file is:\n", n);
                Console.Write("----------------------------------\n");

                while ((s = sr.ReadLine()) != null)
                    Console.WriteLine(" {0} ", s);

                Console.WriteLine();
            }
        }
    }
}
