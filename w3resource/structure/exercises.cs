/*
1. Write a program in C# Sharp to declare a simple structure.
Expected Output:

Declare a simple structure :
--------------------------------
The sum of x and y is 40
*/
namespace Exercises
{
    class Solution
    {
        public static void SolveExercise1()
        {
            Exe1_Structure stt = new Exe1_Structure();
            stt.x = 45;
            stt.y = -41;
            System.Console.WriteLine($"The sum of x and y is: {stt.x + stt.y}");
        }
    }

    struct Exe1_Structure
    {
        public int x;
        public int y;
    }
}
