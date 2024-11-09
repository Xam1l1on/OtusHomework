namespace AnonymousTypesTuplesLambdaExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите программу");
            int numUser = int.Parse(Console.ReadLine());
            switch (numUser)
            {
                case 1:
                    ProgrammOne();
                    break;
                case 2:
                    ProgrammTwo();
                    break;    
                case 3:
                    ProgrammThree();
                    break;
                default: Console.WriteLine();
                    break;
            }

        }
        private static void ProgrammOne()
        {
            var venus1 = new { Name = "Венера", Position = 2, EquatorLength = 38024, PreviousPlanet = (object)null };
            var earth = new { Name = "Земля", Position = 3, EquatorLength = 40075, PreviousPlanet = venus1 };
            var mars = new { Name = "Марс", Position = 4, EquatorLength = 21344, PreviousPlanet = earth };
            var venus2 = new { Name = "Венера", Position = 2, EquatorLength = 38024, PreviousPlanet = mars };

            var planets = new object[] { venus1, earth, mars, venus2 };

            foreach (var planet in planets)
            {
                dynamic p = planet;
                Console.WriteLine($"Название: {p.Name}");
                Console.WriteLine($"Порядковый номер от Солнца: {p.Position}");
                Console.WriteLine($"Длина экватора: {p.EquatorLength}");
                Console.WriteLine($"Предыдущая планета: {(p.PreviousPlanet != null ? (p.PreviousPlanet as dynamic).Name : "нет")}");
                Console.WriteLine($"Эквивалентна Венере: {p.Name == "Венера"}");
                Console.WriteLine(new string('-', 50));
            }
        }
        private static void ProgrammTwo()
        {
            CatalogPlanets planets = new CatalogPlanets();
            var result1 = planets.GetPlanet("Земля");
            Console.WriteLine(result1);
            var result2 = planets.GetPlanet("Лимония");
            Console.WriteLine(result2);
            var result3 = planets.GetPlanet("Марс");
            Console.WriteLine(result3);
        }
        private static void ProgrammThree() 
        {
            int callCount = 0;
            CatalogPlanetsDelegate planets = new CatalogPlanetsDelegate();
            #region Delegates
            Func<string, string> frequentCallValidator = name =>
            {
                callCount++;
                return callCount % 3 == 0 ? "Вы спрашиваете слишком часто" : null;
            };

            Func<string, string> forbiddenPlanetValidator = name =>
            {
                return name.Equals("Лимония") ? "Это запртная планета" : null;
            };
            #endregion

            var result1 = planets.GetPlanet("Земля", frequentCallValidator);
            Console.WriteLine(result1);
            var result2 = planets.GetPlanet("Лимония", frequentCallValidator);
            Console.WriteLine(result2);
            var result3 = planets.GetPlanet("Марс", frequentCallValidator);
            Console.WriteLine(result3);
            Console.WriteLine(new string('-', 50));
            var result4 = planets.GetPlanet("Земля", forbiddenPlanetValidator);
            Console.WriteLine(result4);
            var result5 = planets.GetPlanet("Лимония", forbiddenPlanetValidator);
            Console.WriteLine(result5);
            var result6 = planets.GetPlanet("Марс", forbiddenPlanetValidator);
            Console.WriteLine(result6);

        }
    }
}
