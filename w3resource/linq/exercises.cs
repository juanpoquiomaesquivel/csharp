/*
4. Write a program in C# Sharp to display the number and frequency of a given number from an array.
Expected Output :
The number and the Frequency are :
Number 5 appears 3 times
Number 9 appears 2 times
Number 1 appears 1 times
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

        public static void SolveExercise4()
        {
            int[] nums = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            var n = from x in nums group x by x into y select y;

            foreach (var arrNums in n)
                Console.WriteLine(
                    "Number " + arrNums.Key + " appears " + arrNums.Count() + " times."
                );
        }
    }
}
