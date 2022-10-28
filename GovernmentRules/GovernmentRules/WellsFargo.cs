using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GovernmentRules
{
    internal class WellsFargo : IGovtRules
    {
        public double BasicSalary;
        public float ServiceCompleted;
        public string EmpId;
        public string EmpName;
        public string Designation;

        public WellsFargo(double basicSalary, float serviceCompleted, string empId, string empName, string designation)
        {
            BasicSalary = basicSalary;
            ServiceCompleted = serviceCompleted;
            EmpId = empId;
            EmpName = empName;
            Designation = designation;
        }

        public double EmployeePF(double basicSalary)
        {
            double Epf = 0.12 * BasicSalary;
            double EmpF = 0.12 * BasicSalary;
            double Pf = Epf + EmpF;
            return Pf;
        }

        public double GratuityAmount(float serviceCompleted, double basicSalary)
        {
            return 0;
        }

        public string LeaveDetails()
        {
            int Cl = 2;
            int Sl = 5;
            int Pl = 5;

            string res = $"Casual leaves : {Cl},Sick leaves : {Sl},Privelage leaves : {Pl} ";
            return res;
        }
    }
}
