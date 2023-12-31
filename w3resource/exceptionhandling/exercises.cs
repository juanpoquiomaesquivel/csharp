/*
8. Write a C# program that implements a method that divides two numbers. Handle
the DivideByZeroException that occurs if the denominator is 0.
*/
using System;

namespace Exercises
{
    class Solution
    {
        public static void SolveExercise1()
        {
            try
            {
                string input;
                double num1;

                do
                {
                    System.Console.Write("Number 1: ");
                    input = System.Console.ReadLine()!;
                } while (input == null || input.Replace(" ", "").Length == 0);

                num1 = Convert.ToDouble(input);

                if (Double.IsInfinity(num1))
                    throw new OverflowException("Entered number was too long.");

                double num2;

                do
                {
                    System.Console.Write("Number 2: ");
                    input = System.Console.ReadLine()!;
                } while (input == null || input.Replace(" ", "").Length == 0);

                num2 = Convert.ToDouble(input);

                if (Double.IsInfinity(num2))
                    throw new OverflowException("Entered number was too long.");

                if (num2 == 0)
                    throw new DivideByZeroException("Division by zero is not possible.");
                else
                    System.Console.WriteLine($"Result: {num1 / num2}");
            }
            catch (FormatException)
            {
                System.Console.WriteLine("Error: Non-numeric value was typed.");
            }
            catch (OverflowException ex)
            {
                System.Console.WriteLine($"Error: {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                System.Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                System.Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static void SolveExercise2()
        {
            try
            {
                string input;
                int integer;

                do
                {
                    System.Console.Write("Integer: ");
                    input = System.Console.ReadLine()!;
                } while (input == null || input.Replace(" ", "").Length == 0);

                integer = Convert.ToInt32(input);

                if (integer < 0)
                    throw new NegativeNumberException("Entered number was negative.");
            }
            catch (FormatException)
            {
                System.Console.WriteLine("Error: Non-numeric value was typed.");
            }
            catch (OverflowException ex)
            {
                System.Console.WriteLine($"Error: {ex.Message}");
            }
            catch (NegativeNumberException ex)
            {
                System.Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                System.Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static void SolveExercise3()
        {
            string filePath =
                "C:\\Users_\\Personal\\csharp\\w3resource\\basicexercises\\exercises_.cs";

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    Console.WriteLine("File opened successfully.");
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error: File was not found.");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Error: Directories may be incorrect.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public static void SolveExercise4()
        {
            try
            {
                Console.Write("Input a numeric Integer: ");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number < 0 || number > 1000)
                    throw new NumberOutOfRangeException(
                        "Number out of range. Please enter a number between 0 and 1000."
                    );

                Console.WriteLine("Valid input: {0}", number);
            }
            catch (NumberOutOfRangeException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input. Please enter a numeric integer.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error ocurred: " + ex.Message);
            }
        }

        public static void SolveExercise5()
        {
            try
            {
                // int[] array = { };
                int[] array = { 5, 10, 15 };

                if (array.Length == 0)
                    throw new EmptyArrayException("Array is empty. Cannot calculate the average.");

                double sum = 0;

                for (int i = 0; i < array.Length; i++)
                    sum += array[i];

                double avg = sum / array.Length;

                Console.WriteLine("The average is: " + avg);
            }
            catch (EmptyArrayException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error ocurred: " + ex.Message);
            }
        }

        public static void SolveExercise6()
        {
            try
            {
                Console.Write("Insert a integer number: ");
                string userInput = Console.ReadLine()!;

                int number = int.Parse(userInput);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input. Please enter a valid integer.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error ocurred: " + ex.Message);
            }
        }

        public static void SolveExercise7()
        {
            List<int> integers = new List<int>();

            try
            {
                Console.WriteLine("Input a list of integers (Input 'exit' to finish):");

                while (true)
                {
                    Console.Write("Input an integer: ");
                    string input = Console.ReadLine()!;

                    if (input.ToLower() == "exit")
                        break;

                    int number = int.Parse(input);
                    integers.Add(number);
                }

                Console.WriteLine("Numbers entered:");

                foreach (int number in integers)
                    Console.WriteLine(number);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input. Please enter a valid integer.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: The value entered is outside the range of Int32.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        public static void SolveExercise8()
        {
            int num1,
                num2,
                res;

            try
            {
                Console.Write("Enter the first number: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the second number: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                res = num1 / num2;
                Console.WriteLine("The result of the division is: " + res);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input. Please enter valid integers.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }

    class NegativeNumberException : Exception
    {
        public NegativeNumberException(string message)
            : base(message) { }
    }

    class NumberOutOfRangeException : Exception
    {
        public NumberOutOfRangeException(string message)
            : base(message) { }
    }

    class EmptyArrayException : Exception
    {
        public EmptyArrayException(string message)
            : base(message) { }
    }
}
