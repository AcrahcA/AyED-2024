using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Charca_EsMayor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingresa su edad");
            int edad = int.Parse(Console.ReadLine());
            if (edad < 18)
            {
                Console.WriteLine("sos menor de edad");
            }
            else if (edad > 18)
            {
                Console.WriteLine("sos mayor de edad");
            }
            else
            {
                Console.WriteLine("sos mayor");
            }
            Console.ReadKey();
        }
    }
}
