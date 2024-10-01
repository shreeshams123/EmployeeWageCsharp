using System;
using System.Xml.Schema;

namespace ConsoleApp1
{
    internal class EmployeeWageCompute
    {
        
       
        static int Wageperhour = 20;
        static int Fulltimehour1 = 8;
        static int Parttimehour1 = 4;
        static int isfulltime1 = 0;
        static int isparttime1 = 1;
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the main page of Employee Wage");
            EmployeeWageCompute e = new EmployeeWageCompute();
            ComputeWage();
            e.Caluculatewageswitch();
            e.CheckAttendance();
            e.ComputePartTimeWage();
            e.ComputeDailyWage();
            e.MonthlyWage();
            e.OnCondition();
        }
        static void ComputeWage()
        {
            Random random = new Random();
            int checkemp1 = random.Next(0, 2);
            if (checkemp1 == 0)
            {
                Console.WriteLine("Wage is " + Wageperhour * Fulltimehour1);
            }
            else
            {
                Console.WriteLine("Wage is " + Wageperhour * Parttimehour1);
            }

        }
        public void Caluculatewageswitch()
        {
            int isfulltime = 0;
            int isparttime = 1;
            int wageperhour = 20;
            int fullhour = 8;
            int parthour = 4;
            int wage = 0;
            string res;

            Random r = new Random();
            int checkemp = r.Next(0, 2);

            switch (checkemp)
            {
                case 0: wage = wageperhour * fullhour; break;
                case 1: wage = wageperhour * parthour; break;
            }
            if (checkemp == 0)
            {
                res = "Full Time Employee";
            }
            else
            {
                res = "Part time Employee";
            }
            Console.WriteLine("Wage for " + res + " is " + wage);
        }




        public void ComputePartTimeWage()
        {
            int parttimehour = 4;
            int wageperhour = 20;
            Console.WriteLine("Part time wage is" + parttimehour * wageperhour);

        }
        public void ComputeDailyWage()
        {
            int wageperhour = 20;
            int dailyhour = 8;
            Console.WriteLine("Daily wage is" + wageperhour * dailyhour);
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


        public void OnCondition()
        {
            int totalhours = 0;
            int totaldays = 0;
            int maxhours = 100;
            int maxdays = 20;
            int isFullTime = 0;
            int isPartTime = 1;
            int emphour = 0;
            while (totalhours < maxhours && totaldays < maxdays)

            {
                totaldays++;
                Random r = new Random();
                int checkhour = r.Next(0, 2);
                switch (checkhour)
                {
                    case 0: emphour = 8; break;
                    case 1: emphour = 4; break;
                }
                totalhours += emphour;
            }
            Console.WriteLine("Total wage is" + totalhours * 20);
        }



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


