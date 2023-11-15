/*
2. Write a C# Sharp program to read n values in an array and display
them in reverse order.
Test Data :
Input the number of elements to store in the array :3
Input 3 number of elements in the array :
element - 0 : 2
element - 1 : 5
element - 2 : 7
Expected Output:
The values store into the array are:
2 5 7
The values store into the array in reverse are :
7 5 2
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

            for (var i = 0; i <= 10; i++)
                System.Console.Write(arr[i] + " ");
        }

        public static void SolveExercise2()
        {
            System.Console.Write("Input the number of elements to store in the array: ");
            int n = Convert.ToInt32(System.Console.ReadLine());

            System.Console.WriteLine("Input 10 elements in the array:");
            int[] arr = new int[n];

            for (var i = 0; i < n; i++)
            {
                System.Console.Write($"element - {i}: ");
                arr[i] = Convert.ToInt32(System.Console.ReadLine());
            }

            System.Console.Write("The values store into the array are: ");

            for (var i = 0; i < n; i++)
                System.Console.Write(arr[i] + " ");

            System.Console.Write("\nThe values store into the array in reverse are: ");

            for (var i = n - 1; i >= 0; i--)
                System.Console.Write(arr[i] + " ");
        }
    }
}
