using System.Collections;

namespace SolvingQuadraticEquation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, c = 0;
            bool validInput = false;
            while (!validInput)
            {
                try
                {
                    a = GetData("a");
                    b = GetData("b");
                    c = GetData("c");

                    // Вызов функции для вычисления корней
                    SolveEquation(a, b, c);

                    validInput = true;
                }
                catch (FormatException ex)
                {
                    FormatData(ex.Message, Severity.Error, ex.Data);
                }
                catch (Exception ex)
                {
                    FormatData(ex.Message, Severity.Error, null);
                }
            }
        }
        static int GetData(string variable)
        {
            Console.WriteLine($"Enter a value {variable}:");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int value))
            {
                var ex = new FormatException($"Неверный формат параметра {variable}");
                ex.Data[variable] = input;
                throw ex;
            }
            return value;
        }

        static void SolveEquation(int a, int b, int c)
        {
            try
            {
                double discriminant = b * b - 4 * a * c;

                if (discriminant > 0)
                {
                    double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                    Console.WriteLine($"x1 = {x1}, x2 = {x2}");
                }
                else if (discriminant == 0)
                {
                    double x = -b/(2 * a);
                    Console.WriteLine($"x = {x}");
                }
                else
                {
                    throw new Exception("Вещественных значений не найдено");
                }
            }
            catch (Exception ex)
            {
                if (ex.Message == "Вещественных значений не найдено")
                {
                    FormatData(ex.Message, Severity.Warning, null);
                }
                else
                {
                    throw;
                }
            }
        }

        static void FormatData(string message, Severity severity, IDictionary data)
        {
            if (severity == Severity.Error)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (severity == Severity.Warning)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
            }
            string seperator = new string('-', 50);
            Console.WriteLine(seperator);
            Console.WriteLine($"{severity}: {message} \b");

            if (data != null)
            {
                foreach (DictionaryEntry entry in data)
                {
                    Console.WriteLine($"{entry.Key}: {entry.Value}");
                }
            }
            Console.ResetColor();
        }
    }
}
