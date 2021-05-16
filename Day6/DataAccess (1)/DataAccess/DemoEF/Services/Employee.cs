using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEF.Models
{
    partial class Employee
    {
        public static List<Employee> GetMysoreEmps()
        {
            return new InsuranceContext().Employees.Where(e => e.City == "Mysore").ToList();
        }
    }
}
