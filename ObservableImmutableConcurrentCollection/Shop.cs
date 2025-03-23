using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObservableImmutableConcurrentCollection;

namespace ObservableImmutableConcurrentCollection
{
    public class Shop
    {
        ObservableCollection<Item> items = new ObservableCollection<Item>();
        public Shop()
        {
            items.CollectionChanged += Customer.OnItemChanged;
        }
        /// <summary>
        /// Добавление нового товара
        /// </summary>
        /// <param name="itemName"></param>
        public void Add(string itemName)
        {
            items.Add(new Item(itemName));
        }
        /// <summary>
        /// Удаление товара
        /// </summary>
        /// <param name="itemId">Уникальный номер </param>
        public void Remove(int itemId)
        {
            var itemToRemove = items.FirstOrDefault(item => item.Id == itemId); // Поиск элемента по Id
            if (itemToRemove != null)
            {
                items.Remove(itemToRemove); // Удаление найденного элемента
            }
        }

    }
}
