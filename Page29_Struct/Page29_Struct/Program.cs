﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page29_Struct
{
    struct Emp
    {
        public int id;
        public string name;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Emp e;
            e.id = 1;
            e.name = "홍길동1";
            Console.WriteLine("사번: {0}", e.id );
            Console.WriteLine("이름: {0}", e.name);

            Emp e1 = new Emp();
            e1.id = 2;
            e1.name = "홍길동2";
            Console.WriteLine("사번: {0}", e1.id);
            Console.WriteLine("이름: {0}", e1.name);
        }
    }
}
