/*
5. Write a program in C# Sharp that shows what happens when a structure and a class instance are passed to a method.
Expected Output:

When a structure and a class instance is passed to a method :
--------------------------------------------------------------
ns.n = 5
nc.n = 8
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

        public static void SolveExercise4()
        {
            Console.Write("Assign a value to the class: ");
            Exe4_CRandom v1 = new Exe4_CRandom();
            v1.Value = Convert.ToInt32(Console.ReadLine());

            Console.Write("Assign a value to the struct: ");
            Exe4_SRandom v2 = new Exe4_SRandom();
            v2.Value = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nClass value: {0}, Struct value: {1}", v1.Value, v2.Value);
        }

        public static void SolveExercise5()
        {
            Exe5_CExample cl = new Exe5_CExample();
            Exe5_SExample st = new Exe5_SExample();
            cl.N = 5;
            st.N = 5;

            Console.WriteLine("Printing values: class -> {0}, struct -> {1}", cl.N, st.N);

            _exe5_ChangeClass(cl);
            _exe5_ChangeStruct(st);

            Console.WriteLine(
                "[After methods] Printing values: class -> {0}, struct -> {1}",
                cl.N,
                st.N
            );
        }

        private static void _exe5_ChangeClass(Exe5_CExample cl)
        {
            cl.N = 8;
        }

        private static void _exe5_ChangeStruct(Exe5_SExample st)
        {
            st.N = 8;
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

    class Exe4_CRandom
    {
        public int Value;
    }

    struct Exe4_SRandom
    {
        public int Value;
    }

    class Exe5_CExample
    {
        public int N;
    }

    struct Exe5_SExample
    {
        public int N;
    }
}
