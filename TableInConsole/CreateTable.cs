
using System.Reflection.Metadata.Ecma335;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TableInConsole
{
    public static class CreateTable
    {
        static char symbolPlus = '+';
        static string horizontalBorder = "";
        static int widthString;
        public static void WriteTable(int n, string s)
        {
            Console.Clear();
            int widthString = 2 * n + s.Length;
            horizontalBorder = new string (symbolPlus, widthString);
            for (int i = 0; i < 3; i++)
            {
                switch (i)
                { 
                    case 0:
                        Console.WriteLine($"{symbolPlus}{horizontalBorder}{symbolPlus}");
                        PrintFirstLine(n, s, widthString);
                        break;
                    case 1:
                        Console.WriteLine($"{symbolPlus}{horizontalBorder}{symbolPlus}");
                        PrintSecondLine(n,widthString);
                        break;
                    case 2:
                        Console.WriteLine($"{symbolPlus}{horizontalBorder}{symbolPlus}");
                        PrintThirdLine(widthString);
                        Console.WriteLine($"{symbolPlus}{horizontalBorder}{symbolPlus}");
                        break;
                }
            }
        }
        private static void PrintFirstLine(int n, string s, int totalWidth)
        {
            for (int i = 0; i <= 2 * (n - 1); i++)
            {
                if (i == (n - 1))
                {
                    Console.WriteLine($"+" + new string(' ', n) + s + new string(' ', n) + "+");
                }
                else
                {
                    Console.WriteLine($"+" + new string(' ', n) + new string(' ', s.Length) + new string(' ', n) + "+");
                }
            }
        }
        private static void PrintSecondLine(int n,int totalWidth)
        {
            string line ="";
            int i = 1;
            do
            {
                for (int j = 0; j < totalWidth; j++)
                {
                    if (i % 2 == 0)
                    {
                        line += (j % 2 == 0) ? "+" : " ";
                    }
                    else
                    {
                        line += (j % 2 == 0) ? " " : "+";
                    }
                }
                Console.WriteLine($"{symbolPlus}{line}{symbolPlus}");
                i++;
                line = string.Empty;
            }
            while (i < 2 * n);
        }
        private static void PrintThirdLine(int totalWidth)
        {
            for (int i = 0; i < totalWidth; i++)
            {
                string line = "";
                for (int j = 0; j < totalWidth; j++)
                {
                    line += (i == j || j == totalWidth - i - 1) ? "+" : " ";
                }
                Console.WriteLine($"{symbolPlus}{line}{symbolPlus}");
            }
        }
    }
}
