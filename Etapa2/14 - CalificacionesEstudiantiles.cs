using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14___CalificacionesEstudiantiles
{
    class Program
    {
        static void Main(string[] args)
        {
            int alumnos;
            Console.Write("ingrese la cantidad de alumnos:");
            alumnos = int.Parse(Console.ReadLine());
            Object[,] matriz = new Object[alumnos, 3];
            Console.WriteLine();
            Console.WriteLine("completa las calificaciones de los estudiantes");
            Console.WriteLine();
            for(int i = 0; i< alumnos; i++)
            {
                Console.Write("nombre:");
                matriz[i, 0] = Console.ReadLine();
                Console.Write("edad:");
                matriz[i, 1] = Console.ReadLine();
                Console.Write("Calificación:");
                matriz[i, 2] = Console.ReadLine();
                Console.Clear();
            }

            Console.WriteLine();
            Console.WriteLine("Calificaciones:");
            Console.WriteLine();
            Console.Write("Nombre" + "\t" + "Edad" + "\t" + "calificaciones" + "\t");
            Console.WriteLine();
            for (int i = 0; i< alumnos; i++)
            {
                for(int j = 0; j< 3; j++)
                {
                    Console.Write(matriz[i,j] + "\t");
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
