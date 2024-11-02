﻿namespace AnonymousTypesTuplesLambdaExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите программу");
            Console.ReadLine();

            #region Programm 1
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
            #endregion
            #region Programm 2
            CatalogPlanets planets2 = new CatalogPlanets();
            var result1 = planets2.GetPlanet("Земля");
            Console.WriteLine(result1);
            var result2 = planets2.GetPlanet("Лимония");
            Console.WriteLine(result2);
            var result3 = planets2.GetPlanet("Марс");
            Console.WriteLine(result3);
            #endregion
            #region Programm 3

            #endregion
        }
    }
}