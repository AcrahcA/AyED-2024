using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Charca_BienvenidoACiudad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduce tu nombre");
            String nombre = Console.ReadLine();
            Console.WriteLine("introduce el nombre de una ciudad");
            String ciudad = Console.ReadLine();
            Console.WriteLine("Hola " + nombre + " bienvenido " + ciudad);
            Console.ReadKey();
        }
    }
}
