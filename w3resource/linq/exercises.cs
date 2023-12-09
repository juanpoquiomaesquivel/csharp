/*
3. Write a program in C# Sharp to find the number of an array and the square of each number which is more than 20.
Expected Output :
{ Number = 9, SqrNo = 81 }
{ Number = 8, SqrNo = 64 }
{ Number = 6, SqrNo = 36 }
{ Number = 5, SqrNo = 25 }
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

        public static void SolveExercise3()
        {
            int[] numbers = { 3, 9, 2, 8, 6, 5 };
            var sqr =
                from int Number in numbers
                let SqrNo = Number * Number
                where SqrNo > 20
                select new { Number, SqrNo };
            
            foreach (var item in sqr)
                Console.WriteLine(item);
        }
    }
}
