using System.Diagnostics;

namespace LoopsAndRecursions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = Stopwatch.StartNew();
            do
            {
                Console.WriteLine();
                Console.WriteLine("Введите число");
                int number;
                bool i = int.TryParse(Console.ReadLine(), out number);

                sw.Start();
                var resultRecursion = FibonacciSequenceRecursion(number);
                sw.Stop();
                Console.WriteLine($"Введеное число {number}. Результат рекурсии {resultRecursion}. Затраченное время: {sw.Elapsed.ToString()}");
                sw.Restart();
                sw.Start();
                var resultLoop = FibonacciSequenceLoop(number);
                sw.Stop();
                Console.WriteLine($"Введеное число {number}. Результат цикла {resultLoop}. Затраченное время: {sw.Elapsed.ToString()}");
                sw.Restart();
                Console.WriteLine("Нажмите пробел для выхода из проограммы");
            } while (Console.ReadLine() != " ");
        }
        internal static int FibonacciSequenceRecursion(int n)
        {
            if (n == 0) return 0;
            else if (n == 1) return 1;
            else return FibonacciSequenceRecursion(n - 1) + FibonacciSequenceRecursion(n - 2);
        }
        internal static int FibonacciSequenceLoop(int n)
        {
            int fn1 = 1, fn2 = 0, result = 0;
            if (n == 0) return 0;
            else if (n == 1) return 1;
            else
            {
                for (int i = 2; i <= n; i++)
                {
                    result = fn1 + fn2;
                    fn2 = fn1;
                    fn1 = result;
                }
                return result;
            }
        }
    }
}
