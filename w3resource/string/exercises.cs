/*
1. Write a program in C# Sharp to input a string and print it.
Test Data :
Input the string : Welcome, w3resource
Expected Output :

The string you entered is : Welcome, w3resource 
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
    }
}
