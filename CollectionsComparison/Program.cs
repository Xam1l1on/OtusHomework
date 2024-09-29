using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace CollectionsComparison
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            ArrayList arrayList = new ArrayList();
            LinkedList<int> linkedList = new LinkedList<int>();

            Console.Write(ContainCollectionList(list));
            Console.Write($"    " + ContainCollectionArrayList(arrayList));
            Console.WriteLine($"    " + ContainCollectionLinkedList(linkedList));

            Console.Write(SearchCollectionList(list));
            Console.Write($"    " + SearchCollectionArrayList(arrayList));
            Console.WriteLine($"    " + SearchCollectionLinkedList(linkedList));

            Console.WriteLine(DevideCollectionList(list));
            Console.WriteLine(DevideCollectionArrayList(arrayList));
            Console.WriteLine(DevideCollectionLinkedList(linkedList));
        }
        static string ContainCollectionList(List<int> list)
        {
            Random random = new Random();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i <= 1000000; i++)
            {
                list.Add(random.Next());
            }
            sw.Stop();
            return sw.Elapsed.ToString();
        }
        static string ContainCollectionArrayList(ArrayList list)
        {
            Random random = new Random();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i <= 1000000; i++)
            {
                list.Add(random.Next());
            }
            sw.Stop();
            return sw.Elapsed.ToString();
        }
        static string ContainCollectionLinkedList(LinkedList<int> list)
        {
            Random random = new Random();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i <= 1000000; i++)
            {
                list.AddLast(random.Next());
            }
            sw.Stop();
            return sw.Elapsed.ToString();
        }
        static string SearchCollectionList(List<int> list)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            list.FindIndex(x => x == 496753);
            sw.Stop();
            return sw.Elapsed.ToString();
        }
        static string SearchCollectionArrayList(ArrayList list)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            list.IndexOf(496753);
            sw.Stop();
            return sw.Elapsed.ToString();
        }
        static string SearchCollectionLinkedList(LinkedList<int> list)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            list.Find(496753);
            sw.Stop();
            return sw.Elapsed.ToString();
        }
        static string DevideCollectionList(List<int> list)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            foreach (var item in list)
            {
                if(item % 777 == 0)
                {
                    Console.Write($" " + item);
                }
            }
            sw.Stop();
            Console.WriteLine();
            return sw.Elapsed.ToString();
        }
        static string DevideCollectionArrayList(ArrayList list)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            foreach (int item in list)
            {
                if (item % 777 == 0)
                {
                    Console.Write($" " + item);
                }
            }
            sw.Stop();
            Console.WriteLine();
            return sw.Elapsed.ToString();
        }
        static string DevideCollectionLinkedList(LinkedList<int> list)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            foreach (var item in list)
            {
                if (item % 777 == 0)
                {
                    Console.Write($" " + item);
                }
            }
            sw.Stop();
            Console.WriteLine();
            return sw.Elapsed.ToString();
        }
    }
}
