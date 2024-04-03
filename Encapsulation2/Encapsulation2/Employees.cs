using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation2
{
    public class Employees
    {
        private string employeeName;
        private int employeeAge;


        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }
        public int EmployeeAge
        {
            get { return employeeAge; }
            set { employeeAge = value; }
        }
    }
}
