using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDatabaseGeneratedAttribute
{
    class Program
    {
        static void Main(string[] args)
        {

            EFContext ctx = new EFContext();


            //Deleting the exising data. Other wise primary key error is raised if you run it again
            var all = from e in ctx.Employees select e;
            ctx.Employees.RemoveRange(all);
            ctx.SaveChanges();


            //Inserting the data to employee Table
            Employee emp = new Employee();
            emp.EmployeeID = 1001;
            emp.Name = "Test";
            ctx.Employees.Add(emp);
            ctx.SaveChanges();
            Console.WriteLine("Added  SrNo " + emp.SrNo.ToString());

            emp = new Employee();
            emp.EmployeeID = 2001;
            emp.Name = "Testing Again";
            ctx.Employees.Add(emp);
            ctx.SaveChanges();

            Console.WriteLine("Added  SrNo " + emp.SrNo.ToString());


            Console.WriteLine("Press any key to close");
            Console.ReadKey();

        }
    }
}
