using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restuarant_Management_System
{
    public class Employee
    {
        public int EmployeeID { get; set; }

        public string Name { get; set; }

        public string position { get; set; }

        public double salary { get; set; }

        public string phone { get;set; }

        public Employee(string name, string position, double salary, string phone)
        {
            Name = name;
            this.position = position;
            this.salary = salary;
            this.phone = phone;
        }

        public Employee(int employeeID, string name, string position, double salary, string phone)
        {
            EmployeeID = employeeID;
            Name = name;
            this.position = position;
            this.salary = salary;
            this.phone = phone;
        }
    }
}
