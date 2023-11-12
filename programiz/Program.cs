// C# Variables and (Primitive) Data Types
using System;

namespace DataType // defining a namespace
{
    class Example // defining a class
    {
        static void Main(string[] args) // main method of the program
        {
            sbyte num1 = 127; // declaring and initialiazing a variable
            short num2 = 32767; // '32767' is a literal expression
            int num3 = -51793;
            long number1 = -8445482L; // 'long' is a keyword, 'number' is an identifier
            byte num4 = 0; // all the not decimal numbers from here can be only greather than 0 (unsigned)
            ushort num5 = 64121;
            uint num6 = 705641;
            ulong number2 = 97844121L;
            float decimal1 = 110.45F;
            double decimal2 = -48721.43D;
            char character = 'a';
            string phrase = "we live we love we lie";
            decimal money = 101.15M;
            Console.WriteLine("sbyte => value(num1): " + num1);
            Console.WriteLine("short => value(num2): " + num2);
            Console.WriteLine("int => value(num3): " + num3);
            Console.WriteLine("long => value(number1): " + number1);
            Console.WriteLine("byte => value(num4): " + num4);
            Console.WriteLine("ushort => value(num5): " + num5);
            Console.WriteLine("uint => value(num6): " + num6);
            Console.WriteLine("ulong => value(number2): " + number2);
            Console.WriteLine("float => value(decimal1): " + decimal1);
            Console.WriteLine("double => value(decimal2): " + decimal2);
            Console.WriteLine("char => value(character): " + character);
            Console.WriteLine("string => value(phrase): " + phrase);
            Console.WriteLine("decimal => value(money): " + money);
        }
    }
}
// reference: https://www.programiz.com/csharp-programming/variables-primitive-data-types
