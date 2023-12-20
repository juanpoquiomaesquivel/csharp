/*
5. Write a C# Sharp program to determine the sign of a single value and display it on the console.
Expected Output:
Test the sign of the following types of values:
Byte : 0 is equal to zero.
Int16 : -2 is less than zero.
Int32 : -3 is less than zero.
Int64 : -4 is less than zero.
Single : 2.1 is greater than zero.
Double : 6 is greater than zero.
Decimal: -7 is less than zero.
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

        public static void SolveExercise4()
        {
            decimal[] values = { 10.23m, 10.27m, 14.34m, 11.15m, 41.51m, 10.65m };
            decimal sum = 0;

            foreach (var value in values)
                sum += value;
            Console.WriteLine("True Mean: {0:N2}", sum / values.Length);

            sum = 0;
            foreach (var value in values)
                sum += Math.Round(value, 1, MidpointRounding.AwayFromZero);
            Console.WriteLine("Away From Zero: {0:N2}", sum / values.Length);

            sum = 0;
            foreach (var value in values)
                sum += Math.Round(value, 1, MidpointRounding.ToEven);
            Console.WriteLine("Rounding to Nearest: {0:N2}", sum / values.Length);
        }

        public static void SolveExercise5()
        {
            string strout = "{0}: {1,3} is {2} zero";
            byte xByte1 = 0;
            short xShort1 = -2;
            int xInt1 = -3;
            long xLong1 = -4;
            float xSingle1 = 2.10f;
            double xDouble1 = 6.0;
            decimal xDecimal1 = -7m;

            Console.WriteLine("\nTest the sign of the following types of values:");
            Console.WriteLine(strout, "Byte   ", xByte1, _exe5_Compare(Math.Sign(xByte1)));
            Console.WriteLine(strout, "Int16  ", xShort1, _exe5_Compare(Math.Sign(xShort1)));
            Console.WriteLine(strout, "Int32  ", xInt1, _exe5_Compare(Math.Sign(xInt1)));
            Console.WriteLine(strout, "Int64  ", xLong1, _exe5_Compare(Math.Sign(xLong1)));
            Console.WriteLine(strout, "Single ", xSingle1, _exe5_Compare(Math.Sign(xSingle1)));
            Console.WriteLine(strout, "Double ", xDouble1, _exe5_Compare(Math.Sign(xDouble1)));
            Console.WriteLine(strout, "Decimal", xDecimal1, _exe5_Compare(Math.Sign(xDecimal1)));
        }

        private static string _exe5_Compare(int comp)
        {
            string str = "greater than";

            if (comp == 0)
                str = "equal to";
            else if (comp < 0)
                str = "less than";

            return str;
        }
    }
}
