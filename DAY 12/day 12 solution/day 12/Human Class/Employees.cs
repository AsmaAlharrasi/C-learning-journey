using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace day_12.Human_Class
{
    internal class Employees : Human
    {
        public string Role;
        public string Department;
        public int WorkingHours;
        public int Wage;


        public Employees(int id, string name, int age, bool HasJob, bool IsMarried, string Role, string Department, int WorkingHours, int Wage) : base(id, name, age, HasJob, IsMarried)
        {
            this.Role = Role;
            this.Department = Department;
            this.WorkingHours = WorkingHours;
            this.Wage = Wage;
        }


        public int CalculateSalary(int WorkingHours, int Wage)
        {
            int salary = WorkingHours * Wage;
            return salary;
        }

    }
}


