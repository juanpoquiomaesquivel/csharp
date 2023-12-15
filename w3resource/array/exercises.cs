/*
5. Write a C# Sharp program in to count duplicate elements in an array.
Test Data :
Input the number of elements to be stored in the array :3
Input 3 elements in the array :
element - 0 : 5
element - 1 : 1
element - 2 : 1
Expected Output :
Total number of duplicate elements found in the array is : 1
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

        public static void SolveExercise4()
        {
            Console.Write("Input the number of elements to be stored in the array: ");
            int n = int.Parse(Console.ReadLine()!);
            int[] array = new int[n];
            int[] copiedArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"element-{i}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Copy(array, copiedArray, n);
            Console.WriteLine("\nThe elements stored in the first array are:");

            for (int i = 0; i < n; i++)
                Console.Write(array[i] + " ");

            Console.WriteLine("\nThe elements copied in the second array are:");

            for (int i = 0; i < n; i++)
                Console.Write(copiedArray[i] + " ");
        }

        public static void SolveExercise5()
        {
            int[] numbers = { 1, 98, 56, 2, 56, 2, 15, 1, 2, 2 };
            int count = 0;

            for (int i = 0; i < numbers.Length && numbers[i] != Int32.MinValue; i++)
            {
                bool flag = false;

                for (int j = i + 1; j < numbers.Length; j++)
                    if (numbers[j] == numbers[i])
                    {
                        if (!flag)
                        {
                            count++;
                            flag = true;
                        }

                        numbers[j] = Int32.MinValue;
                    }

                numbers[i] = Int32.MinValue;
            }

            Console.WriteLine("Total number of duplicates is {0}.", count);
        }
    }
}
