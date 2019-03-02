using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_Pyo
{
    class Program
    {
        static void Main(string[] args)
        {
            ////과제 1
            //for (int result = 1; result <= 10; result++)
            //{
            //    if(result % 2 == 0)
            //    {
            //        Console.Write("{0} ", result);
            //    }
            //}
            //Console.WriteLine();


            ////과제2
            //Console.WriteLine("숫자를 입력하세요. ");
            //string str = Console.ReadLine();
            //int m = 0;
            //bool parsed = Int32.TryParse(str, out m);

            //if (!parsed)
            //{
            //    Console.WriteLine("숫자도 입력 못하세요!!");
            //    Environment.Exit(0);
            //}

            //int i = 0, sum = 0;
            //for (i = 1; i <= m; i++)
            //{
            //    Console.Write("{0} ", i);
            //    sum += i;
            //}
            //Console.WriteLine("\n{0}", sum);


            ////과제3
            //Console.WriteLine("숫자 10개를 입력하세요. ");
            //Console.WriteLine("예 : 1,2, ... ,10 ");
            //string str = Console.ReadLine();
            //str.Trim();
            //string[] strarr = str.Split(',');

            //if (strarr.Length != 10)
            //{
            //    Console.WriteLine("숫자 10개를 콤마로 구분해서 입력하세요!!");
            //    return;
            //}

            //int a, b, c, d, e, f, g, h, i, j;
            //double sum = 0;
            //double ave = 0;
            //try
            //{
            //    a = int.Parse(strarr[0]);
            //    b = int.Parse(strarr[1]);
            //    c = int.Parse(strarr[2]);
            //    d = int.Parse(strarr[3]);
            //    e = int.Parse(strarr[4]);
            //    f = int.Parse(strarr[5]);
            //    g = int.Parse(strarr[6]);
            //    h = int.Parse(strarr[7]);
            //    i = int.Parse(strarr[8]);
            //    j = int.Parse(strarr[9]);
            //}
            //catch
            //{
            //    Console.WriteLine("입력이 잘못되었습니다.");
            //    return;
            //}

            //sum = a + b + c + d + e + f + g + h + i + j;
            //ave = sum / 10;

            //Console.WriteLine("10개의 숫자의 합 = {0}", sum);
            //Console.WriteLine("10개의 숫자의 합 = {0}", ave);


            //과제4
            Console.WriteLine("숫자를 입력하세요. ");
            string str = Console.ReadLine();
            int m = 0;
            bool parsed = Int32.TryParse(str, out m);

            if (!parsed)
            {
                Console.WriteLine("숫자도 입력 못하세요!!");
                Environment.Exit(0);
            }
            for (int i = 2; i < 10; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    Console.Write(j + " x " + i + " = " + i * j + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
