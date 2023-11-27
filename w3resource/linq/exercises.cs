/*
2. Write a program in C# Sharp to find the +ve numbers from a list of numbers using
two where conditions in LINQ Query.
Expected Output:
The numbers within the range of 1 to 11 are :
1 3 6 9 10
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

        public static void SolveExercise2()
        {
            int[] n1 = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var nQuery = from vrNum in n1 where vrNum > 0 where vrNum < 12 select vrNum;

            foreach (int vrNum in nQuery)
            {
                System.Console.Write($"{vrNum} ");
            }
        }
    }
}
