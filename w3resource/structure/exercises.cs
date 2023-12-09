/*
3. Write a C# Sharp program to create a nested struct that stores two data for an employee.
Test Data:

Create a nested structure and store data in an array :
-------------------------------------------------------
Name of the employee : H.Rana
Input day of the birth : 05
Input month of the birth : 02
Input year for the birth : 58
                                                                                 
Name of the employee : S.Mathur
Input day of the birth : 04
Input month of the birth : 08
Input year for the birth : 59
*/
using System;

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

        public static void SolveExercise3()
        {
            Exe3_Employee emp1 = new Exe3_Employee();
            Console.Write("Name of the employee: ");
            emp1.Name = Console.ReadLine()!;
            Console.Write("Day of birth: ");
            emp1.DateOfBirth.Day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Month of birth: ");
            emp1.DateOfBirth.Month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Year of birth: ");
            emp1.DateOfBirth.Year = Convert.ToInt32(Console.ReadLine());

            Exe3_Employee emp2 = new Exe3_Employee();
            Console.Write("\nName of the employee: ");
            emp2.Name = Console.ReadLine()!;
            Console.Write("Day of birth: ");
            emp2.DateOfBirth.Day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Month of birth: ");
            emp2.DateOfBirth.Month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Year of birth: ");
            emp2.DateOfBirth.Year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(
                "\nEmployee 1: {0} {1}",
                emp1.Name,
                emp1.DateOfBirth.Day + "/" + emp1.DateOfBirth.Month + "/" + emp1.DateOfBirth.Year
            );
            Console.WriteLine(
                "Employee 2: {0} {1}",
                emp2.Name,
                emp2.DateOfBirth.Day + "/" + emp2.DateOfBirth.Month + "/" + emp2.DateOfBirth.Year
            );
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

    struct Exe3_Employee
    {
        public string Name;
        public Exe3_DateOfBirth DateOfBirth;
    }

    struct Exe3_DateOfBirth
    {
        public int Day;
        public int Month;
        public int Year;
    }
}
