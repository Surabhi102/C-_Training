using System.Data.Entity;

namespace DemoEF.Models
{
    class InsuranceContext: DbContext 
    {
        public InsuranceContext(): base("InsuranceDB")
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Dependant> Dependants { get; set; }
    }
}
