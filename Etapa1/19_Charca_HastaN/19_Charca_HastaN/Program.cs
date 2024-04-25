using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Charca_HastaN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingresa un número");
            int n = int.Parse(Console.ReadLine());
            int n2 = 1;
            while (n2 < n+1)
            {
                if (n2 % 2 == 0)
                {
                    Console.WriteLine(n2);
                }
                n2++;
            }
            Console.ReadKey();
        }
    }
}
