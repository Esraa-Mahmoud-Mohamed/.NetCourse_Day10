using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Employee:IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Security SecurityLevel { get; set; }

        public decimal Salary { get; set; }

        public HireDate Hiredate { get; set; }

        public Gender Gender { get; set; }

        public Employee()
        {
            Id = default;
            Name = default;
            SecurityLevel = default;
            Salary = default;
            Hiredate = default; 
            Gender = default;
        }

        public Employee(int _id, string _name, Security _securitylevel, decimal _salary, HireDate _hireDate, Gender _gender)
        {
            Id = _id;
            Name = _name;
            SecurityLevel = _securitylevel;
            Salary = _salary;
            Hiredate = _hireDate;
            Gender = _gender;
        }

        public override string ToString()
        {
            return String.Format("Employee {0} : {1}, {2}, {3}, {4}, {5}",
                Id,
                Name,
                SecurityLevel,
                Salary.ToString("C", CultureInfo.CurrentCulture),
                Hiredate?.ToString(),
                Gender
               );
        }

        public int CompareTo(object obj)
        {
            Employee emp = (Employee)obj;
            return Hiredate.CompareTo(emp.Hiredate);
        }
    }
}
