using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTaskAddititonal
{
    internal class Manager:Employee
    {
        public Manager(string name, int salary, bool isSuccessful) : base(name, salary, isSuccessful)
        {
            Name = name;
            Salary = salary;
            IsSuccessful=isSuccessful;
        }
        public Manager()
        {

        }

        public int GetPromotion(Employee employee)
        {
            return employee.Salary += 100;
        }
        public int GetMinusPromotion(Employee employee)
        {
            return employee.Salary -= 50;
        }
    }
}
