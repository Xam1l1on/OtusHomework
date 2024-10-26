using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementationOfCollectionClass
{
    internal class NullStackException : Exception
    {
        public NullStackException() { }
        public NullStackException(string message) : base(message) 
        {
        }
    }
}
