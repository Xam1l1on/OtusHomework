namespace LoopsAndRecursions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int number;
            bool i = int.TryParse(Console.ReadLine(), out number);
            if (i) 
            {
                var resultRecursion = FibonacciSequenceRecursion(number);
                Console.WriteLine($"Введеное число {number}. Результат рекурсии {resultRecursion}");

                var resultLoop = FibonacciSequenceLoop(number);
                Console.WriteLine($"Введеное число {number}. Результат цикла {resultLoop}");
            }
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
