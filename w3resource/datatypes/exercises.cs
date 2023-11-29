/*
3. Write a C# Sharp program that takes userid and password as input (string type).
After 3 unsuccessful attempts, the user will be rejected.
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
    }
}
