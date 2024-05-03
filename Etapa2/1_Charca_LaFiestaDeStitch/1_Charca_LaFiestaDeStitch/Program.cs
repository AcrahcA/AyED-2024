using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Charca_LaFiestaDeStitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingresa la cantidad de invitados");
            int invitados = int.Parse(Console.ReadLine());
            int[] losInvitados = new int[invitados];
            bool bucle = true;
            int comida = 0;
            for (int i = 0; i<invitados; i++)
            {
                while (bucle)
                {
                    Console.WriteLine("ingresa la cantidad de comida que consume el invitado " + (i + 1));
                    int cantidad = int.Parse(Console.ReadLine());
                    if (cantidad<1 || cantidad > 100)
                    {
                        bucle = true;         
                    }
                    else if (cantidad>1 || cantidad<100)
                    {
                        bucle = false;
                        losInvitados[i] = cantidad;
                    }
                }
                bucle = true;
                comida = comida + losInvitados[i];
                
            }
            Console.WriteLine("el promedio que sonsume cada invitado es " + (comida/invitados));
            Console.ReadKey();
        }
    }
}
