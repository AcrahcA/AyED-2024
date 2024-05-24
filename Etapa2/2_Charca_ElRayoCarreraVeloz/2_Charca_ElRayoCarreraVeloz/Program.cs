using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Charca_ElRayoCarreraVeloz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingresa la cantidad de vueltas que dio el Rayo McQueen");
            int vueltas = int.Parse(Console.ReadLine());
            int[] lasVueltas = new int[vueltas];
            int tiempoTotal = 0;
            int num = 0;
            for (int i = 0; i < vueltas; i++)
            {
                Console.WriteLine("ingresa la cantidad de tiempo en la vuelta " + (i + 1));
                int tiempo = int.Parse(Console.ReadLine());
                lasVueltas[i] = tiempo;
                tiempoTotal = tiempoTotal + lasVueltas[i];
            }
            for (int i = 0; i < vueltas - 1; i++)
            {
                if (lasVueltas[i] > lasVueltas[i + 1])
                {
                    num = lasVueltas[i + 1];
                    lasVueltas[i + 1] = lasVueltas[i];
                    lasVueltas[i] = num;
                }
            }
            Console.WriteLine("el tiempo total de la carrera es " + tiempoTotal);
            Console.WriteLine("el promedio de tiempo de las vueltas es " + (tiempoTotal/vueltas));
            Console.WriteLine("la mejor vuelta fue " + lasVueltas[0]);
            Console.ReadKey();
        }
    }
}
