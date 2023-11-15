/*
1. Write a C# Sharp program that stores elements in an array and prints them.
Test Data:
Input 10 elements in the array:
element - 0 : 1
element - 1 : 1
element - 2 : 2
.......
Expected Output :
Elements in array are: 1 1 2 3 4 5 6 7 8 9
*/
namespace Exercises
{
    class Solution
    {
        public static void SolveExercise1()
        {
            System.Console.WriteLine("Input 10 elements in the array:");
            int[] arr = new int[10];

            for (var i = 0; i < 10; i++)
            {
                System.Console.Write($"element - {i}: ");
                arr[i] = Convert.ToInt32(System.Console.ReadLine());
            }

            System.Console.Write("Elements in array are: ");

            for (var i = 0; i < 10; i++)
                System.Console.Write(arr[i] + " ");
        }
    }
}
