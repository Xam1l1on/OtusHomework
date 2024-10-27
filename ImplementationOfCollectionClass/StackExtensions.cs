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
            for (var i = stack1.Size; i > 0; i--)
            {
               stack.Add(stack1.Top);
               stack1.Pop();
            }
            return stack;
        }
    }
}
