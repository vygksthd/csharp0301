using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCastExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            short a = 10;
            int b = a;
            int c = 50000;
            short d = (short)c;
            Console.WriteLine("Short : {0}", b);
            Console.WriteLine("Short : {0}", d);
        }
    }
}
