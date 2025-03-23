using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservableImmutableConcurrentCollection
{
    public static class Customer
    {
        public static void OnItemChanged(object? sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach (var newItem in e.NewItems)
                    {
                        if (newItem is Item addedItem)
                            Console.WriteLine($"Добавлен товар: {addedItem.Id} - {addedItem.Name}");
                    }
                    break;

                case NotifyCollectionChangedAction.Remove:
                    foreach (var removedItem in e.OldItems)
                    {
                        if (removedItem is Item deletedItem)
                            Console.WriteLine($"Удален товар: {deletedItem.Id} - {deletedItem.Name}");
                    }
                    break;

                default:
                    Console.WriteLine("Изменения не обработаны.");
                    break;
            }
        }
    }
}
