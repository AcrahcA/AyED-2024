using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13___ObtenerDiagonalPrincipal
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ramdom = new Random();
            Console.Write("ingrese el tamaño de la matriz cuatrada ");
            int tamaño = int.Parse(Console.ReadLine());
            int[] vector = new int[tamaño];
            int[,] matriz = new int[tamaño, tamaño];
            Console.WriteLine();
            Console.WriteLine("Matriz Cuadrada");
            Console.WriteLine();
            for (int i = 0; i < tamaño; i++)
            {
                for (int j = 0; j < tamaño; j++)
                {
                    matriz[i, j] = ramdom.Next(1, 100);
                    Console.Write(matriz[i, j] + "\t");

                }
                Console.WriteLine();
            }
            Console.WriteLine("Diagol de la Matriz");
            Console.WriteLine();
            for (int i = 0; i < tamaño; i++)
            {
                vector[i] = matriz[i, i];
                Console.Write(vector[i] + "\t");
            }
            Console.ReadKey();
        }
    }
}
