using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Charca_ZEGARPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ingrese la cantidad de objetos");
            int objetos = int.Parse(Console.ReadLine());
            int[] losObjetos = new int[objetos];
            Console.WriteLine(" ingrese el valor minimo de los objetos");
            int valorMinimo = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------");
            for (int i = 0; i < objetos; i++)
            {
                Console.WriteLine("ingresa el valor minimo del obejeto " + (i + 1));
                int valor = int.Parse(Console.ReadLine());
                losObjetos[i] = valor;
            }
            Console.WriteLine("----------------------");
            Console.WriteLine("objetos que superan al valor minimo:");
            for (int i = 0; i<objetos; i++)
            {
                if (losObjetos[i] > valorMinimo)
                {
                    Console.WriteLine("objeto " + (i+1));
                }
            }
            Console.ReadKey();

        }
    }
}
