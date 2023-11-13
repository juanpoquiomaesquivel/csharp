/*
1. Write a C# Sharp program to accept two integers and check whether they are equal or not.
Test Data :
Input 1st number: 5
Input 2nd number: 5
Expected Output :
5 and 5 are equal
*/
namespace Exercises
{
    class Solution
    {
        public static void SolveExercise1()
        {
            int x,
                y;
            System.Console.Write("Enter a first number: ");
            x = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("Enter a second number: ");
            y = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("{0} and {1} are {2}", x, y, x == y ? "equal." : "not equal.");
        }
    }
}
