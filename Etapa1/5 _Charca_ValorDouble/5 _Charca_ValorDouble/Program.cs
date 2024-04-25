using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5__Charca_ValorDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dame una altura");
            int altura = int.Parse(Console.ReadLine());
            Console.WriteLine("dame un ancho");
            int ancho = int.Parse(Console.ReadLine());
            Console.WriteLine("el perimetro del rectangulo es " + (ancho * 2 + altura * 2));
            Console.WriteLine("el area del rectangulo es " + (ancho*altura));
            Console.WriteLine("la diagonal del triangulo es " + Math.Sqrt((ancho* ancho + altura*altura)));
            Console.ReadKey();
        }
    }
}
