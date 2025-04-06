using System;
using System.Collections.Generic;

namespace TreesAndHeap
{
    class EmployeeTree<T> where T : IComparable<T>
    {
        public Employees<T> Root { get; private set; }

        public void Insert(string name, T value)
        {
            Root = Insert(Root, name, value);
        }

        private Employees<T> Insert(Employees<T> node, string name, T value)
        {
            if (node == null)
                return new Employees<T>(name, value);

            int compare = value.CompareTo(node.Value);
            if (compare < 0)
                node.Left = Insert(node.Left, name, value);
            else if (compare > 0)
                node.Right = Insert(node.Right, name, value);

            return node;
        }

        public void InOrderTraversal(Employees<T> node)
        {
            if (node == null) return;
            InOrderTraversal(node.Left);
            Console.WriteLine($"{node.Name} - {node.Value}");
            InOrderTraversal(node.Right);
        }

        public string FindByValue(T value)
        {
            var node = Root;
            while (node != null)
            {
                int compare = value.CompareTo(node.Value);
                if (compare == 0)
                    return node.Name;
                else if (compare < 0)
                    node = node.Left;
                else
                    node = node.Right;
            }
            return null;
        }
    }
}
