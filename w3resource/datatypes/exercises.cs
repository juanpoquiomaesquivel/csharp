/*
4. Write a C# Sharp program that takes two numbers as input and performs an
operation (+,-,*,x,/) on them and displays the result of that operation.

Test Data
Input first number: 20
Input operation: -
Input second number: 12
Expected Output :
20 - 12 = 8
*/
namespace Exercises
{
    class Solution
    {
        public static void SolveExercise1()
        {
            char letter1,
                letter2,
                letter3;
            System.Console.Write("Enter letter [1]: ");
            letter1 = Convert.ToChar(System.Console.ReadLine()!);
            System.Console.Write("Enter letter [2]: ");
            letter2 = Convert.ToChar(System.Console.ReadLine()!);
            System.Console.Write("Enter letter [3]: ");
            letter3 = Convert.ToChar(System.Console.ReadLine()!);
            System.Console.Write("{0} {1} {2}", letter3, letter2, letter1);
        }

        public static void SolveExercise2()
        {
            int number,
                width;
            System.Console.Write("Enter a number: ");
            number = int.Parse(System.Console.ReadLine()!);
            System.Console.Write("Enter the desired width: ");
            width = int.Parse(System.Console.ReadLine()!);

            for (int i = width; i >= 1; i--)
            {
                for (int j = i; j >= 1; j--)
                    System.Console.Write(number);

                System.Console.WriteLine();
            }
        }

        public static void SolveExercise3()
        {
            string user = "user",
                password = "admin",
                userInput,
                passwordInput;
            int count = 0;
            bool isSuccessfull;

            do
            {
                Console.WriteLine("Please enter your credentials...");
                count++;
                Console.Write("User: ");
                userInput = Console.ReadLine()!;
                Console.Write("Password: ");
                passwordInput = Console.ReadLine()!;

                isSuccessfull = userInput.Equals(user) && passwordInput.Equals(password);
            } while (count < 3 && !isSuccessfull);

            if (isSuccessfull)
                Console.WriteLine("Logged successfully.");
            else
                Console.WriteLine("The login has failed.");
        }

        public static void SolveExercise4()
        {
            string[] operators = { "+", "-", "*", "/" };

            Console.Write("Input the first number: ");
            int num1 = int.Parse(Console.ReadLine()!);

            Console.Write("Select the operation [+, -, *, /]: ");
            string op = Console.ReadLine()!;

            Console.Write("Input the second number: ");
            int num2 = int.Parse(Console.ReadLine()!);

            int res = 0;

            switch (op)
            {
                case "+":
                    res = num1 + num2;
                    break;
                case "-":
                    res = num1 - num2;
                    break;
                case "*":
                    res = num1 * num2;
                    break;
                case "/":
                    res = num1 / num2;
                    break;
                default:
                    Console.WriteLine("The operation is wrong.");
                    break;
            }

            if (operators.Contains(op))
                Console.WriteLine("{0} {1} {2} = {3}", num1, op, num2, res);
        }
    }
}
