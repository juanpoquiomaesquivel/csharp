/*
1. Write a C# Sharp program to get the absolute value of a number of Decimal values, Double values, Int16 values, Int32 values and Int64 values.
Expected Output:
Absolute value of a number of Decimal values:
Abs(79228162514264337593543950335) = 79228162514264337593543950335
Abs(15.55) = 15.55
Abs(0) = 0
Abs(-17.23) = 17.23
Abs(-79228162514264337593543950335) = 79228162514264337593543950335
Absolute value of a number of Double values:
Abs(1.79769313486232E+308) = 1.79769313486232E+308
Abs(1.5354E-16) = 1.5354E-16
Abs(14.098123) = 14.098123
Abs(0) = 0
Abs(-17.069713) = 17.069713
Abs(-1.4058E+19) = 1.4058E+19
Abs(-1.79769313486232E+308) = 1.79769313486232E+308
Absolute value of a number of Int16 values:
Abs(32767) = 32767
Abs(10328) = 10328
Abs(0) = 0
Abs(-1476) = 1476
Unable to calculate the absolute value of -32768.
Absolute value of a number of Int32 values:
Abs(2147483647) = 2147483647
Abs(16921) = 16921
Abs(0) = 0
Abs(-804128) = 804128
Unable to calculate the absolute value of -2147483648.
Absolute value of a number of Int64 values:
Abs(9223372036854775807) = 9223372036854775807 Abs(109013) = 109013
Abs(0) = 0
Abs(-6871982) = 6871982
Unable to calculate the absolute value of -9223372036854775808.
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
    }
}
