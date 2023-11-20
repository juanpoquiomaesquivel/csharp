/*
1. Write a C# Sharp program to sort a list of elements using Shell sort.
*/
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
    }
}
