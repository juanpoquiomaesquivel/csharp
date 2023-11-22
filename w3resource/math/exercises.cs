/*
2. Write a C# Sharp program to find the maximum and smallest value of two variables.
Expected Output:
Display the greater of two values:
Byte : The greater of 1 and 51 is 51.
Int16 : The greater of -2 and 52 is 52.
Int32 : The greater of -3 and 53 is 53.
Int64 : The greater of -4 and 54 is 54.
Single : The greater of 5 and 55 is 55.
Double : The greater of 6 and 56 is 56.
Decimal: The greater of 7 and 57 is 57.
Display the lesser of two values:
Byte : The lesser of 1 and 51 is 1.
Int16 : The lesser of -2 and 52 is -2.
Int32 : The lesser of -3 and 53 is -3.
Int64 : The lesser of -4 and 54 is -4.
Single : The lesser of 5 and 55 is 5.
Double : The lesser of 6 and 56 is 6.
Decimal: The lesser of 7 and 57 is 7.
*/
namespace Exercises
{
    class Solution
    {
        public static void SolveExercise1()
        {
            decimal[] decimals = { Decimal.MaxValue, 15.55M, 0M, -17.23M, Decimal.MinValue };
            Console.WriteLine("Absolute value of a number of Decimal values:");

            foreach (decimal value in decimals)
                System.Console.WriteLine("Abs({0}) = {1}", value, Math.Abs(value));

            double[] doubles =
            {
                Double.MaxValue,
                1.5354e-16,
                14.098123,
                0,
                17.069713,
                -14.058e18,
                Double.MinValue
            };
            Console.WriteLine("Absolute value of a number of Double values:");

            foreach (double value in doubles)
                System.Console.WriteLine("Abs({0}) = {1}", value, Math.Abs(value));

            short[] int16s = { Int16.MaxValue, 10328, 0, -1476, Int16.MinValue };
            Console.WriteLine("Absolute value of a number of Int16 values:");

            foreach (short value in int16s)
            {
                try
                {
                    Console.WriteLine($"Abs({value}) = {Math.Abs(value)}");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Unable to calculate the absolute value of {0}.", value);
                }
            }

            int[] int32s = { Int32.MaxValue, 16921, 0, -804128, Int32.MinValue };
            Console.WriteLine("Absolute value of a number of Int32 values:");

            foreach (int value in int32s)
            {
                try
                {
                    Console.WriteLine($"Abs({value}) = {Math.Abs(value)}");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Unable to calculate the absolute value of {0}.", value);
                }
            }

            long[] int64s = { Int64.MaxValue, 109013, 0, -6871982, Int64.MinValue };
            Console.WriteLine("Absolute value of a number of Int64 values:");

            foreach (long value in int64s)
            {
                try
                {
                    Console.WriteLine($"Abs({value}) = {Math.Abs(value)}");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Unable to calculate the absolute value of {0}.", value);
                }
            }
        }

        public static void SolveExercise2()
        {
            byte[] bytes = { 1, 51 };
            short[] int16s = { -2, 52 };
            int[] int32s = { -3, 53 };
            long[] int64s = { -4, 54 };
            float[] singles = { 5.0f, 55.0f };
            double[] doubles = { 6.0, 56.0 };
            decimal[] decimals = { 7m, 57m };

            string str = "{0}: The greater of {1,3} and {2,3} is {3}.";

            Console.WriteLine("Display the greater of two values:\n");
            Console.WriteLine(str, "Byte      ", bytes[0], bytes[1], Math.Max(bytes[0], bytes[1]));
            Console.WriteLine(
                str,
                "Int16     ",
                int16s[0],
                int16s[1],
                Math.Max(int16s[0], int16s[1])
            );
            Console.WriteLine(
                str,
                "Int32     ",
                int32s[0],
                int32s[1],
                Math.Max(int32s[0], int32s[1])
            );
            Console.WriteLine(
                str,
                "Int64     ",
                int64s[0],
                int64s[1],
                Math.Max(int64s[0], int64s[1])
            );
            Console.WriteLine(
                str,
                "Single    ",
                singles[0],
                singles[1],
                Math.Max(singles[0], singles[1])
            );
            Console.WriteLine(
                str,
                "Double    ",
                doubles[0],
                doubles[1],
                Math.Max(doubles[0], doubles[1])
            );
            Console.WriteLine(
                str,
                "Decimal   ",
                decimals[0],
                decimals[1],
                Math.Max(decimals[0], decimals[1])
            );

            str = "{0}: The lesser of {1,3} and {2,3} is {3}.";

            Console.WriteLine("\nDisplay the lesser of two values:\n");
            Console.WriteLine(str, "Byte      ", bytes[0], bytes[1], Math.Min(bytes[0], bytes[1]));
            Console.WriteLine(
                str,
                "Int16     ",
                int16s[0],
                int16s[1],
                Math.Min(int16s[0], int16s[1])
            );
            Console.WriteLine(
                str,
                "Int32     ",
                int32s[0],
                int32s[1],
                Math.Min(int32s[0], int32s[1])
            );
            Console.WriteLine(
                str,
                "Int64     ",
                int64s[0],
                int64s[1],
                Math.Min(int64s[0], int64s[1])
            );
            Console.WriteLine(
                str,
                "Single    ",
                singles[0],
                singles[1],
                Math.Min(singles[0], singles[1])
            );
            Console.WriteLine(
                str,
                "Double    ",
                doubles[0],
                doubles[1],
                Math.Min(doubles[0], doubles[1])
            );
            Console.WriteLine(
                str,
                "Decimal   ",
                decimals[0],
                decimals[1],
                Math.Min(decimals[0], decimals[1])
            );
        }
    }
}
