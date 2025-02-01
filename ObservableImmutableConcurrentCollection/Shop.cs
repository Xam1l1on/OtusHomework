using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservableImmutableConcurrentCollection
{
    public class Shop
    {
        List<Item> items;
        public void Add(Item item)
        {
            //Observable collection, при добавлении item обновляется информация в Customer
        }
        public void Remove(Item item)
        {

        }
    }
}
