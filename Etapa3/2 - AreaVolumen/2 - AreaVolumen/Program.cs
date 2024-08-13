using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___AreaVolumen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese el radio del circurlo ");
            int radio = int.Parse(Console.ReadLine());
            Console.Write("ingrese el alto del cilindro ");
            int altura = int.Parse(Console.ReadLine());
            Console.WriteLine("el area del circulo es: " + area(radio));
            Console.WriteLine("el volumen del cilindro es: " + volumen(radio, altura));
            Console.ReadKey();
        }
        static double area(double r)
        {
            r = Math.PI * r;
            return r;
        }
        static double volumen(double volumen, int h)
        {
            volumen = Math.PI * (volumen*volumen)*h;
            return volumen;
        }
    }
}
