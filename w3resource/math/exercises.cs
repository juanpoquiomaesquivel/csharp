/*
3. Write a C# Sharp program to calculate the value that results from raising 3 to a power ranging from 0 to 32.
3^0 = 1 (0x1)
3^1 = 3 (0x3)
3^2 = 9 (0x9)
3^3 = 27 (0x1B)
3^4 = 81 (0x51)
3^5 = 243 (0xF3)
3^6 = 729 (0x2D9)
3^7 = 2,187 (0x88B)
3^8 = 6,561 (0x19A1)
3^9 = 19,683 (0x4CE3)
3^10 = 59,049 (0xE6A9)
3^11 = 177,147 (0x2B3FB)
3^12 = 531,441 (0x81BF1)
3^13 = 1,594,323 (0x1853D3)
3^14 = 4,782,969 (0x48FB79)
3^15 = 14,348,907 (0xDAF26B)
3^16 = 43,046,721 (0x290D741)
3^17 = 129,140,163 (0x7B285C3)
3^18 = 387,420,489 (0x17179149)
3^19 = 1,162,261,467 (0x4546B3DB)
3^20 = 3,486,784,401 (0xCFD41B91)
3^21 = 10,460,353,203 (0x26F7C52B3)
3^22 = 31,381,059,609 (0x74E74F819)
3^23 = 94,143,178,827 (0x15EB5EE84B)
3^24 = 282,429,536,481 (0x41C21CB8E1)
3^25 = 847,288,609,443 (0xC546562AA3)
3^26 = 2,541,865,828,329 (0x24FD3027FE9)
3^27 = 7,625,597,484,987 (0x6EF79077FBB)
3^28 = 22,876,792,454,961 (0x14CE6B167F31)
3^29 = 68,630,377,364,883 (0x3E6B41437D93)
3^30 = 205,891,132,094,649 (0xBB41C3CA78B9)
3^31 = 617,673,396,283,947 (0x231C54B5F6A2B)
3^32 = 1,853,020,188,851,841 (0x6954FE21E3E81)
*/
using System;

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

        public static void SolveExercise3()
        {
            int value = 3;

            for (int power = 0; power <= 32; power++)
                Console.WriteLine(
                    $"{value}^{power} = {(long)Math.Pow(value, power):N0} (0x{(long)Math.Pow(value, power):X})"
                );
        }
    }
}
