using System.Runtime.CompilerServices;

namespace TreesAndHeap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var tree = new EmployeeTree<int>();
                Console.WriteLine("Введите имя сотрудника (пустая строка - завершить ввод):");
                while (true)
                {
                    string name = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(name)) break;

                    Console.WriteLine("Введите зарплату сотрудника:");
                    if (int.TryParse(Console.ReadLine(), out int salary))
                    {
                        tree.Insert(name, salary);
                    }
                    else
                    {
                        Console.WriteLine("Некорректная зарплата. Попробуйте снова.");
                    }
                    Console.WriteLine("Введите имя сотрудника (пустая строка - завершить ввод):");
                }

                Console.WriteLine("Сотрудники в порядке возрастания зарплаты:");
                tree.InOrderTraversal(tree.Root);

                while (true)
                {
                    Console.WriteLine("Введите зарплату для поиска сотрудника:");
                    if (int.TryParse(Console.ReadLine(), out int searchSalary))
                    {
                        var result = tree.FindByValue(searchSalary);
                        if (result != null)
                            Console.WriteLine($"Сотрудник с зарплатой {searchSalary}: {result}");
                        else
                            Console.WriteLine("такой сотрудник не найден");
                    }
                    else
                    {
                        Console.WriteLine("Некорректная зарплата.");
                    }

                    Console.WriteLine("Введите 0 для ввода нового списка сотрудников или 1 для нового поиска:");
                    var choice = Console.ReadLine();
                    if (choice == "0") break;
                    if (choice != "1")
                    {
                        Console.WriteLine("Некорректный выбор. Возврат к началу программы.");
                        break;
                    }
                }
            }
        }
    }
}
