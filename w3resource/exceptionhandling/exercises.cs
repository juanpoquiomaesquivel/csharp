/*
3. Write a C# program that reads a file path from the user and tries to
open the file. Handle exceptions if the file does not exist.
*/
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
    }

    class NegativeNumberException : Exception
    {
        public NegativeNumberException(string message)
            : base(message) { }
    }
}
