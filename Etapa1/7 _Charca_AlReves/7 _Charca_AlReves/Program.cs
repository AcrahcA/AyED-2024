using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7__Charca_AlReves
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingresa una letra");
            char letra = char.Parse(Console.ReadLine());
            Console.WriteLine("ingresa otra letra");
            char letra1 = char.Parse(Console.ReadLine());
            Console.WriteLine("ingresa otra letra");
            char letra2 = char.Parse(Console.ReadLine());
            Console.WriteLine(letra2);
            Console.WriteLine(letra1);
            Console.WriteLine(letra);
            Console.ReadKey();

        }
    }
}
