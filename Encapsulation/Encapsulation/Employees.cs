using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
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
