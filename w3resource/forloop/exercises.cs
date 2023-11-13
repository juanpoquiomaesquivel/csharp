/*
1. Write a program in C# Sharp to display the first 10 natural numbers.
Expected Output :
1 2 3 4 5 6 7 8 9 10
*/
namespace Exercises
{
    class Solution
    {
        public static void SolveExercise1()
        {
            for (var i = 1; i <= 10; i++)
                System.Console.Write(i + " ");
        }
    }
}
