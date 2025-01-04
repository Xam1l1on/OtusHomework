using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TreesAndHeap
{
    class Employees
    {
        private  string _nameEmp;
        private  double _salaryEmp;
        public  string NameEmp { get { return _nameEmp; } set { _nameEmp = value; } }
        public  double SalaryEmp { get { return _salaryEmp; } set { _salaryEmp = value; } }

        public override string ToString()
        {
            return NameEmp + " " + SalaryEmp;
        }
    }
}
