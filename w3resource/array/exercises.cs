/*
3. Write a program in C# Sharp to find the sum of all array elements.
Test Data :
Input the number of elements to be stored in the array :3
Input 3 elements in the array :
element - 0 : 2
element - 1 : 5
element - 2 : 8
Expected Output :
Sum of all elements stored in the array is : 15
*/
using System;

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

        public static void SolveExercise3()
        {
            Console.Write("Input the number of elements to be stored in the array: ");
            int n = int.Parse(Console.ReadLine()!);
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"element-{i}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"The sum of elements stored in the array is: {array.Sum()}");
        }
    }
}
