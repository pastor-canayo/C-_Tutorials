using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Utilities
    {
        public static int CalculateYearlyWage(int monthlyWage, int yearlyWage)
        {
            //Console.WriteLine($"Yearly Wage: {monthlyWage * yearlyWage}");
            return monthlyWage * yearlyWage;
        }
        public static int CalculateYearlyWage(int monthlyWage, int yearlyWage, int bonus)
        {
            //Console.WriteLine($"Yearly Wage: {monthlyWage * yearlyWage}");
            return monthlyWage * yearlyWage + bonus;
        }
    }
}
