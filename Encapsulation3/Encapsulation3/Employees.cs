using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation3
{
    public class Employees
    {
        private string employeeName;
        private int employeeAge;
        private int employeeId;

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
        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }
    }
}
