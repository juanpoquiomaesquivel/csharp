/*
1. Write a program in C# Sharp to show how the three parts of a query operation execute.
Expected Output:
The numbers which produce the remainder 0 after divided by 2 are :
0 2 4 6 8
*/
namespace Exercises
{
    class Solution
    {
        public static void SolveExercise1()
        {
            int[] ds = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var nQuery = from vrNum in ds where (vrNum % 2) == 0 select vrNum;

            foreach (int vrNum in nQuery)
            {
                System.Console.Write($"{vrNum} ");
            }
        }
    }
}
