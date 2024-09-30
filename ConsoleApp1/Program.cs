using System;

namespace ConsoleApp1
{
    internal class EmployeeWageCompute
    {
       public void ComputeDailyWage()
        {
            int wageperhour = 20;
            int dailyhour = 8;
            Console.WriteLine("Daily wage is"+wageperhour*dailyhour);
        }
    }
}
