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
        public ushort Position { get; set; }
        public int EquatorLength { get; set; }
        public Planet? PreviousPlanet { get; set; }
        public Planet(string name, ushort position, int equatorLenght, Planet? prevPlanet = null) 
        {
            Name = name;
            Position = position;
            EquatorLength = equatorLenght;
            PreviousPlanet = prevPlanet;
        }

    }
}
