using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homwork10
{
    internal class File: FileWorker
    {
        public override string Extension { get; set; } = "txt";

        public override void Read() => Console.WriteLine($"I can read from {Extension} file with max storage {MaxSize}");

        public override void Write() => Console.WriteLine($"I can write to {Extension} file with max storage {MaxSize}");

        public override void Edit() => Console.WriteLine($"I can edit {Extension} file with max storage {MaxSize}");

        public override void Delete() => Console.WriteLine($"I can delete from {Extension} file with max storage {MaxSize}");

    }
}
