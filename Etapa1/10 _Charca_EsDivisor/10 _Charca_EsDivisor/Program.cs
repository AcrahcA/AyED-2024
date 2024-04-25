using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10__Charca_EsDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingresa un numero");
            float num = float.Parse(Console.ReadLine());
            Console.WriteLine("ingresa otro numero");
            float num2 = float.Parse(Console.ReadLine());
            if (num == 0)
            {
                Console.WriteLine("ERROR");
            }
            else
            {
                Console.WriteLine(num + " /" + num2 + " = " + (num / num2));
            }
            Console.ReadKey();
        }
    }
}
