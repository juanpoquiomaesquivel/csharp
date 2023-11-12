// C# Variables and (Primitive) Data Types
using System;

namespace Operator // defining a namespace
{
    class Example // defining a class
    {
        static void Main(string[] args) // main method of the program
        {
            double dec1 = 15.31D, dec2 = 8.05D, result;
            int int1 = 15, int2 = 6, mod;

            /* ARITHMETIC OPERATORS */

            // addition
            result = dec1 + dec2;
            Console.WriteLine("{0} + {1} = {2}", dec1, dec2, result);

            // substraction
            result = dec1 - dec2;
            Console.WriteLine("{0} - {1} = {2}", dec1, dec2, result);

            // multiplication
            result = dec1 * dec2;
            Console.WriteLine("{0} * {1} = {2}", dec1, dec2, result);

            // division
            result = dec1 / dec2;
            Console.WriteLine("{0} / {1} = {2}", dec1, dec2, result);

            // module
            mod = int1 % int2;
            Console.WriteLine("{0} % {1} = {2}", int1, int2, mod);

            /* RELATIONAL OPERATOR */
            bool value;
            int val1 = 4, val2 = 3;

            // equal to
            value = (val1 == val2);
            Console.WriteLine("{0} == {1} -> {2}", val1, val2, value);

            // equal to
            value = (val1 != val2);
            Console.WriteLine("{0} != {1} -> {2}", val1, val2, value);

            // greather than
            value = (val1 > val2);
            Console.WriteLine("{0} > {1} -> {2}", val1, val2, value);

            // greather than or equal to
            value = (val1 >= val2);
            Console.WriteLine("{0} >= {1} -> {2}", val1, val2, value);

            // less than
            value = (val1 < val2);
            Console.WriteLine("{0} < {1} -> {2}", val1, val2, value);

            // less than or equal to
            value = (val1 <= val2);
            Console.WriteLine("{0} <= {1} -> {2}", val1, val2, value);

            /* LOGICAL OPERATORS */
            bool flag1 = true, flag2 = false;

            // and
            value = flag1 && flag2;
            Console.WriteLine("{0} && {1} -> {2}", flag1, flag2, value); 

            // or
            value = flag1 || flag2;
            Console.WriteLine("{0} || {1} -> {2}", flag1, flag2, value);

            /* UNARY OPERATORS */
            int age = 15, falseAge = -25;

            // unary plus
            age = +falseAge;
            Console.WriteLine("unary plus -> {0}", age);

            // unary minus
            age = -falseAge;
            Console.WriteLine("unary plus -> {0}", age);

            // increment
            ++age; // is equal to 'age = ++age'
            Console.WriteLine("increment -> {0}", age);

            // decrement
            --age; // 'age--' works totally different, the change is seen in the next line
            Console.WriteLine("decrement -> {0}", age);

            // logical negation
            value = !(age == falseAge);
            Console.WriteLine("not -> {0}", value);

            /* TERNARY OPERATOR */
            bool flag = (falseAge > 0 ? true : false);

            Console.WriteLine("ternary -> {0}", flag);

            /* There are also bitwise, bitshift and compound operators */
        }
    }
}
// reference: https://www.programiz.com/csharp-programming/variables-primitive-data-types
