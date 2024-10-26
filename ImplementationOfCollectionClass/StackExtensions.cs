using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementationOfCollectionClass
{
    internal static class StackExtensions
    {
        public static Stack Merge(this Stack stack, Stack stack1)
        {
            stack1 = new Stack();
            return stack;
        }
    }
}
