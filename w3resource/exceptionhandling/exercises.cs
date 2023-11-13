/*
1. Write a C# program that prompts the user to input two numbers
and divides them. Handle an exception when the user enters non-numeric values.
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
                    input = System.Console.ReadLine();
                } while (input == null || input.Replace(" ", "").Length == 0);

                num1 = Convert.ToDouble(input);

                if (Double.IsInfinity(num1))
                    throw new OverflowException("Entered number was too long.");

                double num2;

                do
                {
                    System.Console.Write("Number 2: ");
                    input = System.Console.ReadLine();
                } while (input == null || input.Replace(" ", "").Length == 0);

                num2 = Convert.ToDouble(input);

                if (Double.IsInfinity(num2))
                    throw new OverflowException("Entered number was too long.");

                if (num2 == 0)
                    throw new DivideByZeroException("Division by zero is not possible.");
                else
                    System.Console.WriteLine($"Result: {num1 / num2}");
            }
            catch (FormatException ex)
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
    }
}
