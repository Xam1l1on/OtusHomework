using System.Runtime.CompilerServices;

namespace TreesAndHeap
{
    internal class Program
    {
        private static Employees _employees;
        private static List<Employees> emp = new List<Employees>();
        private static ConstructionTree<Employees?> _constructionTree = new ConstructionTree<Employees?>();
        static void Main(string[] args)
        {
            _employees = new Employees();
            do
            {
                Console.Write($"Имя сотрудника ");
                _employees.NameEmp = Console.ReadLine();
                Console.Write($"Зарплата сотрудника ");
                _employees.SalaryEmp = double.Parse(Console.ReadLine());
                //Console.WriteLine(_employees.ToString());
                ConstructionBST(_constructionTree);
            }
            while (_employees.NameEmp != "");
        }
        internal static void ConstructionBST(ConstructionTree<Employees?> constructionTree)
        {
            if(constructionTree is null)
            {
                constructionTree = new ConstructionTree<Employees?>();
            }
        }
        internal static void Traverse(ConstructionTree<Employees> construction)
        {
            if(construction.LeftNode != null)
            {
                Traverse(construction.LeftNode);
            }
            Console.WriteLine(construction.Value.ToString());
            if(construction.RightNode != null)
            {
                Traverse(construction.RightNode);
            }
        }
    }
}
