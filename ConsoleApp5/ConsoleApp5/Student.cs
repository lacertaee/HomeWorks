using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Student
    {
        public string name;
        public int age, year;

        const int yearsToFinish = 4;

        public Student(string name, int age, int year)
        {
            this.name = name;
            this.age = age;
            this.year = year;
        }

        public string GetRandomSubject()
        {
            var random = new Random();
            var subjects = new List<string> { "Math", "Chemistry", "English", "Biology", "History"};
            var index = random.Next(subjects.Count);
            return subjects[index];
        }

        public int YearsLeft()
        {
            return yearsToFinish - year;
        }
    }
}
