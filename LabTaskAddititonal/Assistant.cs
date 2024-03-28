using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTaskAddititonal
{
    internal class Assistant : Employee
    {
        public Assistant(string name, int salary, bool isSuccessful) : base(name, salary, isSuccessful)
        {
        }
        public Assistant()
        {

        }
        public int GetFeedBack(Employee employee)
        {
            Manager manager = new();
            if (employee.IsSuccessful == true)
            {
                return manager.GetPromotion(employee);
            }
            else
            {
                return manager.GetMinusPromotion(employee);
            }

        }
    }
}
