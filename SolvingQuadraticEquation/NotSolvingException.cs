using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolvingQuadraticEquation
{
    internal class NotSolvingException : Exception
    {
        public NotSolvingException() : base() { }
        public NotSolvingException(string message) : base(message)
        {
        }
    }
}
