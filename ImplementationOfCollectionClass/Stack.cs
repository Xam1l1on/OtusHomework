using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementationOfCollectionClass
{
    internal class Stack
    {
        private List<string> _elementsList;

        public Stack(params string[] initialElementsList)
        {
            _elementsList = new List<string>(initialElementsList);
        }

        public void Add(string element)
        {
            _elementsList.Add(element);
        }

        public string Pop()
        {
            if (_elementsList.Count == 0)
            {
                throw new InvalidOperationException("Стек пустой");
            }

            string topElement = _elementsList[^1];
            _elementsList.RemoveAt(_elementsList.Count - 1);
            return topElement;
        }

        public int Size
        {
            get => _elementsList.Count;
        }

        public string Top
        {
            get
            {
                if( _elementsList.Count == 0)
                {
                    throw new NullReferenceException("Стек пустой");
                }
                string topElement = _elementsList[_elementsList.Count - 1];
                return topElement;
            }
        }
        public static Stack Concat(Stack[] stackArray)
        {

            return new Stack();
        }
    }
}
