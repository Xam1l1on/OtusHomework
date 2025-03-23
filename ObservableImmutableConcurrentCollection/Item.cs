using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ObservableImmutableConcurrentCollection
{
    public class Item
    {
        private static int lastId = 0;
        public int Id {  get; private set; }
        public string Name { get; set; }
        public Item(string name)
        {
            Id = ++lastId;
            Name = name;
        }
    }
}
