using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page26_Value
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = a;

            Console.WriteLine(a);
            Console.WriteLine(b);

            b = 2;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
