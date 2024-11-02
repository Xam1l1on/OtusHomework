using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypesTuplesLambdaExpressions
{
    internal class Planet
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public int EquatorLength { get; set; }
        public Planet PreviousPlanet { get; set; }
        public Planet() { }
        public Planet(string name) { }

    }
}
