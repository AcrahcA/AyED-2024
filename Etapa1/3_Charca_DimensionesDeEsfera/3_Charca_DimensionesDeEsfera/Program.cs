using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Charca_DimensionesDeEsfera
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduce un numero para el radio de la esfera");
            int radio = int.Parse(Console.ReadLine());
            float pi = 3.14f;
            Console.WriteLine("la supericie de la esfera es " + (4 * pi * radio*radio));
            Console.WriteLine("el volumen de la esfera es " + ((3 * pi * radio*radio*radio)/4));
            Console.ReadKey();
        }
    }
}
