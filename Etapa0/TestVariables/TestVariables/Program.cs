using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            String cadena = "15,557294";
            int entero = 15;
            bool boolean = false;
            float flotante = 15.557294f;
            double doble = 15.557294;
            Char caracter = '1';

            Console.WriteLine("String " + cadena);
            Console.WriteLine("int " + entero);
            Console.WriteLine("bool " + boolean);
            Console.WriteLine("float " + flotante);
            Console.WriteLine("double " + doble);
            Console.WriteLine("char " + caracter);

            entero = int.Parse(Console.ReadLine());

            Console.ReadKey();

        }
    }
}
