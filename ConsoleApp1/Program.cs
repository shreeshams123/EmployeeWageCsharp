using System;
using System.Xml.Schema;

namespace ConsoleApp1
{
    internal class EmployeeWageCompute
    {

        public void MonthlyWage()
        {
            int isfulltime = 0;
            int isparttime = 1;
            int NoOfDays = 20;
            int emphour=0;
            int totalwage = 0;
            for (int i = 0; i < NoOfDays; i++)
            {
                Random r = new Random();
                int emptype = r.Next(0, 2);
                switch (emptype)
                {
                    case 0:
                        emphour = 8;
                        break;
                    case 1: emphour = 4; break;
                }
                totalwage += emphour;
            }
            Console.WriteLine("Total wage is " + totalwage);
        }
    }
}

