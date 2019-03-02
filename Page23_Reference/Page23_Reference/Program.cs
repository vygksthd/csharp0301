using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page23_Reference
{
    class Rtype
    {
        public object Value;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rtype a = new Rtype();
            Rtype b = new Rtype();

            a.Value = 1;
            Console.WriteLine(a.Value);

            b.Value = 2;
            Console.WriteLine(b.Value);
        }
    }
}
