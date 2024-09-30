using System;

namespace ConsoleApp1
{
    internal class EmployeeWageCompute
    {
        static int Wageperhour = 20;
        static int Fulltimehour1 = 8;
        static int Parttimehour1 = 4;
        static int isfulltime1 = 0;
        static int isparttime1 = 1;
        static void ComputeWage()
        {
           Random random = new Random();
            int checkemp1=random.Next(0,2);
            if (checkemp1 == 0)
            {
                Console.WriteLine("Wage is " + Wageperhour * Fulltimehour1);
            }
            else
            {
                Console.WriteLine("Wage is " + Wageperhour * Parttimehour1);
            }
        }
    }
}

