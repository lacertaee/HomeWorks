using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class LazyStudent : Student2
    {
        public LazyStudent(string name) : base(name)
        {
        }

        public override void Study()
        {
            Console.WriteLine($"{name} is too lazy to study");
        }

        public override void Read()
        {
            Console.WriteLine($"{name} doesn't like to read");
        }

        public override void Write()
        {
            Console.WriteLine($"{name} doesn't like to write");
        }

        public override void Relax()
        {
            Console.WriteLine($"{name} likes to relax all the time");
        }

    }
}
