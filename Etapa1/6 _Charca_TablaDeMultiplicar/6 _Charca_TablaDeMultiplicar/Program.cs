using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6__Charca_TablaDeMultiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingresa un numero");
            int num = int.Parse(Console.ReadLine());
            int num2 = 1;
            while (num2 < 11)
            {
                Console.WriteLine(num + " * 1= " + (num*num2));
                num2 ++;
            }
            Console.ReadKey();
        }
    }
}
