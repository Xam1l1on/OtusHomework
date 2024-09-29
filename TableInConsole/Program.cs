namespace TableInConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userNumber;
            string userString;


            //The user enters any number.
            Console.WriteLine("Введите число от 1 до 6");
            if (!int.TryParse(Console.ReadLine(), out userNumber))
            {
                Console.WriteLine($"Это не число. Пока");
                return;
            }
            else if (userNumber < 1 && userNumber > 6)
            {
                Console.WriteLine("Число должно быть больше 1 именьше 6");
                return;
            }
            //The user enters any word.
            Console.WriteLine("Введите слово");
            userString = Console.ReadLine();
            if(string.IsNullOrEmpty(userString))
            {
                Console.WriteLine("Напиши хоть что-то");
                return;
            }
            //Make the table
            CreateTable.WriteTable(userNumber, userString);
        }

    }
}
