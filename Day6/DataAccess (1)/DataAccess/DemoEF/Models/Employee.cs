using System.Collections.Generic;

namespace DemoEF.Models
{
    partial class Employee
    {        
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public List<Dependant> Dependants { get; set; }

        public Employee()
        {
            Dependants = new List<Dependant>();
        }
    }
}
