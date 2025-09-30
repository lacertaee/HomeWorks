using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Student2
    {
        protected string name;
        public Student2 (string name)
        {
            this.name = name;
        }

        public virtual void Study()
        {
            Console.WriteLine($"{name} is studying");
        }

        public virtual void Read()
        {
            Console.WriteLine($"{name} is reading");
        }

        public virtual void Write()
        {
            Console.WriteLine($"{name} is writing");
        }

        public virtual void Relax()
        {
            Console.WriteLine($"{name} is relaxing");
        }

        public void Working()
        {
            Study();
            Read();
            Write();
            Relax();
        }

        public string GetName()
        {
            return name;
        }

    }
}
