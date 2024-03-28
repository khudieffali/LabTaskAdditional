using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTaskAddititonal
{
    internal class Employee
    {
        public string Name;
        public int Salary;
        public bool IsSuccessful;
        public Employee(string name, int salary, bool isSuccessful)
        {
            Name = name;
            Salary = salary;
            IsSuccessful = isSuccessful;
        }
        public Employee()
        {

        }
    }
}
