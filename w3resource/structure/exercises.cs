/*
2. Write a program in C# Sharp to declare a simple structure and use static fields inside a struct.
Expected Output :

Structure with the use of static fields inside a structure :
---------------------------------------------------------
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

        public static void SolveExercise2()
        {
            int sum = Exe2_Structure.x + Exe2_Structure.y;
            System.Console.WriteLine($"The sum of x and y is: {sum}");
        }
    }

    struct Exe1_Structure
    {
        public int x;
        public int y;
    }

    struct Exe2_Structure
    {
        public static int x = 56;
        public static int y = 3;
    }
}
