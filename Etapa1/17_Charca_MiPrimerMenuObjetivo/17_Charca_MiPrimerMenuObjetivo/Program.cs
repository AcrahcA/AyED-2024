using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Charca_MiPrimerMenuObjetivo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repetir = true;
            while (repetir)
            {
                int num = 1;
                int num2 = 2;
                int num3 = 3;
                int num4 = 4;
                Console.WriteLine("--- Menú ---");
                Console.WriteLine("1.Opcion 1: saludos");
                Console.WriteLine("2.Opcion 2: suma matematica de 2 +2");
                Console.WriteLine("3.Opcion 3: saludo doble");
                Console.WriteLine("4.Salir");
                Console.WriteLine("elije una opcion");

                int num5 = int.Parse(Console.ReadLine());
                if (num5 == num)
                {
                    Console.Clear();
                    Console.WriteLine("Hola :D");
                    Console.WriteLine();
                    
      
                }
                

                else if (num5 == num2)
                {
                    Console.Clear();
                    Console.WriteLine("2+2=4");
                    Console.WriteLine();
                }
                else if (num5 == num3)
                {
                    Console.Clear();
                    Console.WriteLine("Hola Hola");
                    Console.WriteLine();
                }
                else if (num5 == num4)
                {
                    repetir = false;
                    Console.Clear();
                }
                

            }
            
         
            Console.ReadKey();
            
        }
    }
}
