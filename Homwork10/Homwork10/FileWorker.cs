using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homwork10
{
    internal abstract class FileWorker
    {
        public int MaxSize { get; set; }

        public abstract string Extension {  get; set; }

        public virtual void Read() => Console.WriteLine($"I can read from {Extension} file with max storage {MaxSize}");

        public virtual void Write() => Console.WriteLine($"I can write to {Extension} file with max storage {MaxSize}");

        public virtual void Edit() => Console.WriteLine($"I can edit {Extension} file with max storage {MaxSize}");

        public virtual void Delete() => Console.WriteLine($"I can delete from {Extension} file with max storage {MaxSize}");





    }
}
