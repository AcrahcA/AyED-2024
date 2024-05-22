using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Charca_ContratacionSoft
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ingrese la cantidad de candidatos que realizaron el examen");
            int candidatos = int.Parse(Console.ReadLine());
            int[] losCandidatos = new int[candidatos];
            int orden = 0;
            Console.WriteLine("------------------------------");
            for (int i = 0; i < candidatos; i++)
            {
                Console.WriteLine("ingresa el puntaje del candidato "+ (i+1));
                int puntos = int.Parse(Console.ReadLine());
                losCandidatos[i] = puntos;
            }
            for (int i = 0; i < candidatos - 1; i++)

            {
                for (int t = 0; t < candidatos - 1; t++)
                {
                    if (losCandidatos[t] > losCandidatos[t + 1])
                    {
                        orden = losCandidatos[t + 1];
                        losCandidatos[t + 1] = losCandidatos[t];
                        losCandidatos[t] = orden;
                    }
                }
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("ingrese un número entero");
            int numeroEntero = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");
            Console.WriteLine("lista con los puntajes ordenados:");
            for (int i = 0; i < candidatos; i++)
            {
                Console.WriteLine(losCandidatos[i]);
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("lista de los puntajes que son múltiplos del número especificado:");
            for (int i= 0; i < candidatos; i++)
            {
                if (losCandidatos[i] % numeroEntero==0)
                {
                    Console.WriteLine(losCandidatos[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
