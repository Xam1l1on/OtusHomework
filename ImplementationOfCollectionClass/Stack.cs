using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
            try
            {
                string topElement = _elementsList[^1];
                _elementsList.RemoveAt(_elementsList.Count - 1);
                return topElement;
            }
            catch (IndexOutOfRangeException)
            {
                return "Стэк пустой";
            }

        }

        public int Size
        {
            get => _elementsList.Count;
        }

        public string Top
        {
            get
            {
                try
                {
                    string topElement = _elementsList[_elementsList.Count - 1];
                    return topElement;
                }
                catch (ArgumentOutOfRangeException)
                {
                    return null;
                }
            }
        }
        public static Stack Concat(params Stack[] stackArray)
        {
            Stack stack = new Stack();
            for (int i = 0; i <= stackArray.Length - 1; i++)
            {
                for (int j = stackArray[i].Size; j > 0; j--)
                {
                    stack.Add(stackArray[i].Top);
                    stackArray[i].Pop();
                }
            }
            return stack;
        }
    }

}
