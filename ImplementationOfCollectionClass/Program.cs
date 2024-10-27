﻿namespace ImplementationOfCollectionClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            var s = new Stack("a", "b", "c");

            // size = 3, Top = 'c'
            Console.WriteLine($"size = {s.Size}, Top = '{s.Top}'");

            var deleted = s.Pop();

            // Извлек верхний элемент 'c' Size = 2
            Console.WriteLine($"Извлек верхний элемент '{deleted}' Size = {s.Size}");
            s.Add("d");

            // size = 3, Top = 'd'
            Console.WriteLine($"size = {s.Size}, Top = '{s.Top}'");

            s.Pop();
            s.Pop();
            s.Pop();
            // size = 0, Top = null
            Console.WriteLine($"size = {s.Size}, Top = {(s.Top == null ? "null" : s.Top)}");
            s.Pop();
            */

            /*
            var s = new Stack("a", "b", "c");

            s.Merge(new Stack("1", "2", "3"));
            Console.WriteLine($"before stack = {s.Top}; after merge {s.Top}");
            for (int i = s.Size; i > 0; i--)
            {
                Console.Write(s.Top);
                Console.Write(", ");
                s.Pop();
            }
            // в стеке s теперь элементы - "a", "b", "c", "3", "2", "1" <- верхний
            */
            var s = Stack.Concat(new Stack("a", "b", "c"), new Stack("1", "2", "3"), new Stack("А", "Б", "В"));
            for (int i = s.Size; i > 0; i--)
            {
                Console.Write(s.Top);
                Console.Write(", ");
                s.Pop();
            }

        }
    }
}
