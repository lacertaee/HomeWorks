using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class ClassRoom
    {
        readonly List<Student2> classroom = new List<Student2>();

        public ClassRoom(List<Student2> students)
        {
            classroom = students;
        }

        public void GetStudentMethods()
        {
            foreach (var student in classroom)
            {
                Console.WriteLine(student.GetName() + ": ");
                student.Working();
            }
        }
    }
}
