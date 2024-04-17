using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingClass
{
    internal class Utilities
    {
        public static int CalculateYearlyWage(int monthlyWage, int yearlyWage)
        {
            //Console.WriteLine($"Yearly Wage: {monthlyWage * yearlyWage}");
            return monthlyWage * yearlyWage;
        }
       
    }
}
