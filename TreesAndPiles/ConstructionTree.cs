using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreesAndHeap
{
    class ConstructionTree<T>
    {
        public T? Value { get; set; }
        public ConstructionTree<T> LeftNode { get; set; }
        public ConstructionTree<T> RightNode { get; set; }
    }
}
