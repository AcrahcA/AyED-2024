using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Charca_ParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dame un numero");
            int num = int.Parse(Console.ReadLine());
            if ((num % 2) == 0)
            {
                Console.WriteLine("el numero es par");
            }
            else
            {
                Console.WriteLine("el numero es impar");
            }
            Console.ReadKey();
        }
    }
}
