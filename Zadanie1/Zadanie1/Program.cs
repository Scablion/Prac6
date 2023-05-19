using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Program
    {

        static int fx(int a)
        {
            int secNum = a % 100 / 10;

            return secNum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("число 1 - ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("число 2 - ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("число 3 - ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine($"f({a}) + f({b}) - f({c}) = " + (fx(a) + fx(b) - fx(c)) );
        }
    }
}
