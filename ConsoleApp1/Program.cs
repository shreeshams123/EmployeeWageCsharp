using System;

namespace ConsoleApp1
{
    internal class EmployeeWageCompute
    {
        public void OnCondition()
        {
            int totalhours = 0;
            int totaldays = 0;
            int maxhours = 100;
            int maxdays = 20;
            int isFullTime = 0;
            int isPartTime = 1;
            int emphour = 0;
            while(totalhours< maxhours && totaldays < maxdays)
            {
                totaldays++;
                Random r=new Random();
                int checkhour = r.Next(0, 2);
                switch (checkhour)
                {
                    case 0: emphour = 8; break;
                    case 1: emphour = 4; break;
                }
                totalhours += emphour;
            }
            Console.WriteLine("Total wage is" + totalhours);
        }

    }
}

