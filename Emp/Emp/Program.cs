using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp
{
    class Emp
    {
        private int _Empno;
        public int Empno { get; set; } = 998;
    }
    class Program
    {    
        static void Main(string[] args)
        {
            Emp e = new Emp();
            e.Empno = 999;
            Console.WriteLine(e.Empno);
        }
    }
}
