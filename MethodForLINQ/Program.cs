namespace MethodForLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var top30 = numbers.Top(30);
            Console.WriteLine("Top 30% чисел:");
            Console.WriteLine(string.Join(", ", top30));

            var people = new List<Person>
            {
                new Person { Name = "Alice", Age = 30 },
                new Person { Name = "Bob", Age = 40 },
                new Person { Name = "Charlie", Age = 50 },
                new Person { Name = "Diana", Age = 20 },
                new Person { Name = "Eve", Age = 35 },
            };

            var top40ByAge = people.Top(40, p => p.Age);
            Console.WriteLine("\nTop 40% по возрасту:");
            foreach (var p in top40ByAge)
            {
                Console.WriteLine(p);
            }
        }
    }
}
