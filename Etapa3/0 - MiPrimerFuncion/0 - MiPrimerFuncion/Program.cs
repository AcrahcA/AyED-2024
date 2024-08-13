using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0___MiPrimerFuncion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese su nombre");
            String name = Console.ReadLine();
            Console.WriteLine(saludo(name));
            Console.ReadKey();
        }
        static String saludo(String nombre)
        {
            Console.WriteLine("Hola" + nombre);
            return nombre;
        }
    }
}
