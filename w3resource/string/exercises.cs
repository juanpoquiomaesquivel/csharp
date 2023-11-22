/*
2. Write a C# Sharp program to find the length of a string without using a library function.
Test Data :
Input the string : w3resource.com
Expected Output :

Length of the string is : 15 
*/
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
    }
}
