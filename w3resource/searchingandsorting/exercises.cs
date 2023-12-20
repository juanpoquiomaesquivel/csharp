/*
3. Write a C# Sharp program to sort a list of elements using Bubble sort.
*/
using System;

namespace Exercises
{
    class Solution
    {
        public static void SolveExercise1()
        {
            int[] array = { 1, 8, -6, 0, 25, -78 };
            int n = array.Length;

            for (uint i = 0; i < n; i++)
                System.Console.Write(array[i] + " ");

            _exe1_shellSort(array);
            System.Console.WriteLine("\nAfter shell sort...");

            for (uint i = 0; i < n; i++)
                System.Console.Write(array[i] + " ");
        }

        private static void _exe1_shellSort(int[] array)
        {
            int aux,
                k;
            int n = array.Length;

            for (int rsn = n / 2; rsn > 0; rsn /= 2)
            for (int i = rsn; i < n; i++)
            {
                aux = array[i];
                k = i - rsn;

                while (k >= 0 && aux < array[k])
                {
                    array[k + rsn] = array[k];
                    k -= rsn;
                }

                array[k + rsn] = aux;
            }
        }

        public static void SolveExercise2()
        {
            List<int> array = new List<int>() { 1, 8, -6, 0, 25, -78 };
            int n = array.Count;

            for (int i = 0; i < n; i++)
                Console.Write(array[i] + " ");

            Console.WriteLine();
            array = _exe2_bogoSort(array.ToList());
            Console.WriteLine("\nAfter bogo sort...");

            for (int i = 0; i < n; i++)
                Console.Write(array[i] + " ");
        }

        private static List<int> _exe2_bogoSort(List<int> array)
        {
            int ite = 0;

            while (!_exe2_isSorted(array))
            {
                Console.Write("Iteration {0} -> ", ite++);

                for (int i = 0; i < array.Count; i++)
                    Console.Write(array[i] + " ");

                Console.WriteLine();
                array = _exe2_reMap(array);
            }

            return array;
        }

        private static bool _exe2_isSorted(List<int> array)
        {
            for (int i = 0; i < array.Count - 1; i++)
                if (array[i] > array[i + 1])
                    return false;

            return true;
        }

        private static List<int> _exe2_reMap(List<int> array)
        {
            int temp;
            List<int> newArray = new List<int>();
            Random r = new Random();

            while (array.Count > 0)
            {
                temp = (int)r.Next(array.Count);
                newArray.Add(array[temp]);
                array.RemoveAt(temp);
            }

            return newArray;
        }

        public static void SolveExercise3()
        {
            int[] array = { 1, 8, -6, 0, 25, -78 };
            int n = array.Length;

            for (uint i = 0; i < n; i++)
                System.Console.Write(array[i] + " ");

            _exe3_bubbleSort(array);
            System.Console.WriteLine("\nAfter bubble sort...");

            for (uint i = 0; i < n; i++)
                System.Console.Write(array[i] + " ");
        }

        private static void _exe3_bubbleSort(int[] array)
        {
            int temp = 0;
            int n = array.Length;

            for (int i = 1; i < n; i++)
            for (int j = n - 1; j >= i; j--)
                if (array[j - 1] > array[j])
                {
                    temp = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = temp;
                }
        }
    }
}
