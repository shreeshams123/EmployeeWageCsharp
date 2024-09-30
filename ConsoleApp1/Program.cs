using System;

namespace ConsoleApp1
{
    internal class EmployeeWageCompute
    {
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
        }
    }


