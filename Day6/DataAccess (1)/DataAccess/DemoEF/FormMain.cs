using DemoEF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoEF
{    
    public partial class FormMain : Form
    {
        InsuranceContext ctx;
        public FormMain()
        {
            InitializeComponent();
            CenterToScreen();

            ctx = new InsuranceContext();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {            
            var emps = GetEmps();
            
            string msg;
            if (emps.Any())
                msg = $"Got {emps.Count} Emps from DB";
            else
                msg = "No Emps found";

            MessageBox.Show(msg);
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            var strEmpName = txtName.Text;
            var strDepName = txtDependent.Text;

            //object initialization syntax
            var emp = new Employee() { Name = strEmpName, City = "Mysore" };
            var dep = new Dependant() { Name = strDepName, Age = 65 };            

            emp.Dependants.Add(dep);            

            if (WriteEmp(emp))
                MessageBox.Show("Done");
            else
                MessageBox.Show("Could not write employee");

        }        

        private void btnQuery1_Click(object sender, EventArgs e)
        {
            //LINQ to Entities
            var emps = ctx.Employees.Where(emp => emp.City == "Mysore");

            if (emps.Any())
            {
                foreach (var emp in emps)
                    MessageBox.Show(emp.Name);
            }
            else
                MessageBox.Show("No result for query");
        }

        private void btnQuery2_Click(object sender, EventArgs evt)
        {
            //Get a list of all those emps who have any dependant who is 60 and above
            var emps = ctx.Employees
               .Where(emp => emp.Dependants.Any(d => d.Age >= 60));
            
            if (emps.Any())
            {
                foreach (var emp in emps)
                    MessageBox.Show(emp.Name);
            }
            else
                MessageBox.Show("No result for query");
        }


        private List<Employee> GetEmps() => ctx.Employees.ToList();

        private bool WriteEmp(Employee employee)
        {
            bool success = false;

            try
            {
                ctx.Employees.Add(employee);
                ctx.SaveChanges();
                success = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return success;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Employee firstEmp = ctx.Employees.Find(1);
            //var state1 = ctx.Entry<Employee>(firstEmp).State; //unchanged
            try
            {
                firstEmp.Name = "Ravi K Ram";

                Dependant dep = firstEmp.Dependants.Where(d => d.Age < 60).First();                
                dep.Name = "Changed Name";

                //var state2 = ctx.Entry<Employee>(firstEmp).State; //Modified

                ctx.SaveChanges(); //change tracking mechanism
                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
        }
    }
}
