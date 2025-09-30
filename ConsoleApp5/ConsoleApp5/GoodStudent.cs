using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class GoodStudent : Student2
    {

        public GoodStudent(string name) : base(name)
        {
        }

        public override void Study()
        {
            Console.WriteLine($"{name} is studying hard");
        }

        public override void Read()
        {
            Console.WriteLine($"{name} is reading more");
        }

        public override void Write()
        {
            Console.WriteLine($"{name} is writing more");
        }

        public override void Relax()
        {
            Console.WriteLine($"{name} likes to relax but only after studying");
        }

    }
}
