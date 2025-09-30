using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Teacher
    {
        public string name, status;

        public Teacher(string name, string status)
        {
            this.name = name;
            this.status = status;
        }

        public string Check(string subject)
        {
            var random = new Random();
            switch (subject.ToLower())
            {
                case "math":
                    return $"{random.Next(10) + random.Next(10)}";
                case "chemistry":
                    return "H2O";
                case "english":
                    return "Hello World";
                default:
                    return "ar aris kompetenturi";
            }
        }
    }
}
