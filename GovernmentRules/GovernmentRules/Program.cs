using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GovernmentRules
{
    class Program
    {
        static void Main(string[] args)
        {
            TCS t = new TCS(20000, 7, "e16", "Safoora", "System Engineer");
            WellsFargo w = new WellsFargo(30000, 10, "e17", "Sahaja", "Program Associate");
            Console.WriteLine("Company :TCS");
            Console.WriteLine("Employee Name :" + t.EmpName);
            Console.WriteLine("Employee Id :" + t.EmpId);
            Console.WriteLine("Employee Designation :" + t.Designation);
            Console.WriteLine("Employee Basic Salary :" + t.BasicSalary);
            Console.WriteLine("No of years employee worked in the organization :" + t.ServiceCompleted);
            Console.WriteLine("Employee Provident Fund :" + t.EmployeePF(t.BasicSalary));
            Console.WriteLine("Employee Leave details :" + t.LeaveDetails());
            Console.WriteLine("Employee Gratuity  :" + t.GratuityAmount(t.ServiceCompleted,t.BasicSalary));

            Console.WriteLine("Company :WellsFargo");
            Console.WriteLine("Employee Name :" + w.EmpName);
            Console.WriteLine("Employee Id :" + w.EmpId);
            Console.WriteLine("Employee Designation :" + w.Designation);
            Console.WriteLine("Employee Basic Salary :" + w.BasicSalary);
            Console.WriteLine("No of years employee worked in the organization :" + w.ServiceCompleted);
            Console.WriteLine("Employee Provident Fund :" + w.EmployeePF(w.BasicSalary));
            Console.WriteLine("Employee Leave details :" + w.LeaveDetails());
            Console.WriteLine("Employee Gratuity  :" + w.GratuityAmount(w.ServiceCompleted, w.BasicSalary));
        }

    }
}
