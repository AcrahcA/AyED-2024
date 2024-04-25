using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Charca_DiezVeces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingresa una palabra");
            String palabra = Console.ReadLine();
            Console.WriteLine("--------------------------------------------");
            for (int i = 0; i<11; i++)
            {
                Console.WriteLine(palabra);
            }
            Console.ReadKey();

        }
    }
}
