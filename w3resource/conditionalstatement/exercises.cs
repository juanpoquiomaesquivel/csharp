/*
2. Write a C# Sharp program to check whether a given number is even or odd.
Test Data : 15
Expected Output :
15 is an odd integer
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

        public static void SolveExercise2()
        {
            int num;
            System.Console.Write("Enter the number: ");
            num = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("{0} is an {1} integer", num, num % 2 == 0 ? "even" : "odd");
        }
    }
}
