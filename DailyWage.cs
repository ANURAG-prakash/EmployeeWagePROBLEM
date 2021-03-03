using System;

namespace DailyWage
{
    class Program
    {
        static void Main(string[] args)
        {
            int Wage_Per_Hour = 20;
            int Total_Hour_Per_Day = 8;
            int Daily_Employee_Wage = Wage_Per_Hour * Total_Hour_Per_Day;
            Console.WriteLine("Daily wage of the employee is " + Daily_Employee_Wage);
        }
    }
}
