using System;

namespace ConsoleApp1
{
    internal class EmployeeWageCompute
    {
        public void ComputePartTimeWage()
        {
            int parttimehour = 4;
            int wageperhour = 20;
            Console.WriteLine("Part time wage is" + parttimehour * wageperhour);
        }
       
    }
}
