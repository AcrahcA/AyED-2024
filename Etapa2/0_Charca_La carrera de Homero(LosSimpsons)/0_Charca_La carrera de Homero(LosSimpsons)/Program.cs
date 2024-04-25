using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Charca_La_carrera_de_Homero_LosSimpsons_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingresa la cantidad de obstáculos.");
            int obstaculos =int.Parse( Console.ReadLine());
            int[] losObstaculos = new int[obstaculos];
            String si = "si";
            String no = "no";
            int puntos = 0;
            for (int i=0; i < obstaculos; i++)
            {
                Console.WriteLine("Homero supera el Obstaculo "+(i+1));
                String respuesta = Console.ReadLine();
                if (respuesta == si)
                {
                    losObstaculos[i] = 10;
                }
                else if(respuesta==no)
                {
                    losObstaculos[i] = - 5;
                }
                else if(!(respuesta==si || respuesta==no))
                {
                    Console.WriteLine("Homero supera el Obstaculo " + (i + 1));
                    String respuesta2 = Console.ReadLine();
                    if (respuesta2 == si)
                    {
                        losObstaculos[i] = 10;
                    }
                    else if (respuesta2 == no)
                    {
                        losObstaculos[i] = -5;
                    }

                }
                puntos = puntos + losObstaculos[i];

            }
            Console.WriteLine("homero gano "+ puntos + " puntos");
            Console.ReadKey();


        }
    }
}
