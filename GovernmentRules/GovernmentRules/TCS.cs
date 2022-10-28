using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GovernmentRules
{
    internal class TCS : IGovtRules
    {
        public double BasicSalary;
        public float ServiceCompleted;
        public string EmpId;
        public string EmpName; 
        public string Designation;

        public TCS(double basicSalary, float serviceCompleted, string empId, string empName, string designation)
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
            double EmpF=0.0833 * BasicSalary;
            double Pf = Epf + EmpF;
            double PensionFund = 0.0367 * BasicSalary;
            return Pf;
        }

        public string LeaveDetails()
        {
            int Cl = 1;
            int Sl = 12;
            int Pl = 10;

            string res = $"Casual leaves : {Cl},Sick leaves : {Sl},Privelage leaves : {Pl} ";
            return res;

        }

        public double GratuityAmount(float serviceCompleted, double basicSalary)
        {
            switch (serviceCompleted)
            {
                case var g when g >= 20: return 3 * BasicSalary;
                case var g when g >= 10: return 2 * BasicSalary;
                case var g when g >= 5:return 1 * BasicSalary;
                default: return 0;

            }

        }
    }
}
