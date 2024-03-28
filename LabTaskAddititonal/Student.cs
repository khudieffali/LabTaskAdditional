using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTaskAddititonal
{
    internal class Student:Person
    {
        public bool IsOnline;

        public Student(string name, string surname, byte age, bool isOnline) : base(name, surname, age)
        {
            IsOnline = isOnline;
        }
    }
}
