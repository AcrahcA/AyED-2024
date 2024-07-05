using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9___MiPrimerMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingresa una cantidad de filas ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("ingresa una cantidad de columnas ");
            int m = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int r = int.Parse(Console.ReadLine());
                    matriz[i, j] = r;
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine("");

            }
            
            Console.ReadKey();
        }
    }
}
