/*
2. Write a program in C# Sharp to create a user defined function with parameters.
Test Data :
Please input a name : John
Expected Output :
Welcome friend John !
Have a nice day!
*/
namespace Exercises
{
    class Solution
    {
        public static void SolveExercise1()
        {
            System.Console.WriteLine("THIS IS AN EXAMPLE OF AN USER DEFINED FUNCTION!");
            _exe1_Welcome();
        }

        private static void _exe1_Welcome()
        {
            System.Console.WriteLine("Welcome To This World!");
        }

        public static void SolveExercise2()
        {
            System.Console.Write("Tell me your name: ");
            string? yourName = System.Console.ReadLine();
            _exe2_WelcomeTo(yourName);
        }

        private static void _exe2_WelcomeTo(string? yourName)
        {
            System.Console.WriteLine("Welcome To This World! {0}", yourName);
        }
    }
}
