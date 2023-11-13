/*
1. Write a C# Sharp program that takes three letters and displays them in reverse order.
Test Data
Enter letter: b
Enter letter: a
Enter letter: t
Expected Output :
t a b
*/
namespace Exercises
{
    class Solution
    {
        public static void SolveExercise1()
        {
            char letter1, letter2, letter3;
            System.Console.Write("Enter letter [1]: ");
            letter1 = Convert.ToChar(System.Console.ReadLine()!);
            System.Console.Write("Enter letter [2]: ");
            letter2 = Convert.ToChar(System.Console.ReadLine()!);
            System.Console.Write("Enter letter [3]: ");
            letter3 = Convert.ToChar(System.Console.ReadLine()!);
            System.Console.Write("{0} {1} {2}", letter3, letter2, letter1);
        }
    }
}
