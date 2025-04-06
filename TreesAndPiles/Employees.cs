using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TreesAndHeap
{
    class Employees<T>
    {
        public string Name { get; set; }
        public T Value { get; set; }
        public Employees<T> Left { get; set; }
        public Employees<T> Right { get; set; }

        public Employees(string name, T value)
        {
            Name = name;
            Value = value;
        }
    }
}
