using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypesTuplesLambdaExpressions
{
    class CatalogPlanetsDelegate
    {
        List<Planet> planets;
        private int requestCount = 0;

        public CatalogPlanetsDelegate()
        {
            Planet venera = new Planet("Венера", 2, 38024);
            Planet earth = new Planet("Земля", 3, 40075, venera);
            Planet mars = new Planet("Марс", 4, 21344, earth);
            planets = new List<Planet> { venera, earth, mars };
        }
        internal (ushort?, int?, string) GetPlanet(string namePlanet, Func<string, string> PlanetValidatorDelegate)
        {
            string validatorError = PlanetValidatorDelegate(namePlanet);
            if (validatorError != null)
            {
                return (null, null, validatorError);
            }
            //requestCount++;
            //if (requestCount % 3 == 0)
            //{
            //    return (null, null, "Вы спрашиваете слишком часто");
            //}
            Planet foundPlanet = planets.Find(p => p.Name.Equals(namePlanet));
            if (foundPlanet != null)
            {
                return (foundPlanet.Position, foundPlanet.EquatorLength, null);
            }
            else
            {
                return (null, null, "Планета не  найдена");
            }
        }
    }
}
