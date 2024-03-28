using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTaskAddititonal
{
    internal class Group
    {
        public string GroupName;
        public Student[] Student;

        public Group(string groupName, Student[] studens)
        {
            GroupName = groupName;
            Student = studens;
        }

        public void GetAll()
        {
            foreach (var st in Student)
            {
                Console.WriteLine(st.Name + " " + st.Surname);
            }
        }

        public void GetOnlineStudents()
        {
            foreach (var st in Student)
            {
                if (st.IsOnline) Console.WriteLine(st.Name + " " + st.Surname + " Online tehsil alirlar");
            }
        }
        public void GetOfflineStudents()
        {
            foreach (var st in Student)
            {
                if (!st.IsOnline) Console.WriteLine(st.Name + " " + st.Surname + " Offline tehsil alirlar");
            }
        }
    }
}
