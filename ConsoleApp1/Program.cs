using System;

namespace ConsoleApp1
{
    internal class EmployeeWageCompute
    {


        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the main page of Employee Wage");
            EmployeeWageCompute e = new EmployeeWageCompute();
            e.CheckAttendance();
        }
        public void CheckAttendance()
        {
            Random r = new Random();
            int isPresent = r.Next(0, 2);
            if (isPresent == 0)
            {
                Console.WriteLine("Employee is absent");
            }
            else if (isPresent == 1)
            {
                Console.WriteLine("Employee is present");
            }
        }

        public void ComputeDailyWage()
        {
            int wageperhour = 20;
            int dailyhour = 8;
            Console.WriteLine("Daily wage is" + wageperhour * dailyhour);

        }

    }
}

