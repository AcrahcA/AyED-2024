using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Charca_HastaQueSI
{
    class Program
    {
        static void Main(string[] args)
        {
            bool bucle = true;
            String si = "SI";
            while (bucle)
            {
                Console.WriteLine("Deseas terminar el programa");
                String respuestas = Console.ReadLine();
                
                if (respuestas == si)
                {
                    bucle = false;
                }
            }

            Console.ReadKey();
        }
    }
}
