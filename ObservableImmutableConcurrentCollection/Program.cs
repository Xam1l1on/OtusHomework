namespace ObservableImmutableConcurrentCollection
{
    public class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            while (true)
            {
                Console.WriteLine("\nВыберите действие:");
                Console.WriteLine("A - Добавить новый товар");
                Console.WriteLine("D - Удалить товар по ID");
                Console.WriteLine("X - Выйти из программы");

                var key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.A:
                        string newItemName = $"Товар от {DateTime.Now}";
                        shop.Add(newItemName);
                        Console.WriteLine($"Добавлен: {newItemName}");
                        break;

                    case ConsoleKey.D:
                        Console.WriteLine("Введите ID товара для удаления:");
                        if (int.TryParse(Console.ReadLine(), out int itemId))
                        {
                            shop.Remove(itemId);
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод ID.");
                        }
                        break;

                    case ConsoleKey.X:
                        Console.WriteLine("Выход из программы.");
                        return;

                    default:
                        Console.WriteLine("Неверная команда. Попробуйте снова.");
                        break;
                }
            }
        }
    }
}
