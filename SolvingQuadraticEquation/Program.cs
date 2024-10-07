namespace SolvingQuadraticEquation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            int[] arrayValue = new int[2];
            Console.WriteLine($"a * x^2 + b * x + c = 0");
            Console.WriteLine("Введите значение a:");
            string sUserInput1 = Console.ReadLine();
            Console.WriteLine("Введите значение b:");
            string sUserInput2 = Console.ReadLine();
            Console.WriteLine("Введите значение c:");
            string sUserInput = Console.ReadLine();
            try
            {
                for(int i = 0; i <= arrayValue.Length; i++)
                {
                    arrayValue[i] = int.Parse(sUserInput1);
                }
            }
            catch (Exception)
            {
                throw;
            }
            //SolvingQuadraticEquation(a, b, c);
        }
        static void SolvingQuadraticEquation(int a, int b, int c)
        {

        }
        static void FormatData(bool check)
        {
            try
            {

            }
            catch (Exception e)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("-------------------------");
                Console.WriteLine($"Неверный формат параметра : {check} {e.Data}");
            }
        }
    }
}
