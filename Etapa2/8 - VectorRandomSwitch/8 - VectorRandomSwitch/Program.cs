using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8___VectorRandomSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            bool bucle2 = true;
            Console.WriteLine("ingrese el tamaño del vector");
            int tamaño = int.Parse(Console.ReadLine());
            int[] losVector = new int[tamaño];
            Random aleatorio = new Random();
            for (int i = 0; i < tamaño; i++)
            {
                int numers = aleatorio.Next(1, 100);
                losVector[i] = numers;
            }
            while (bucle2)
            {
               
                Console.WriteLine("-------------Menu-------------");
                Console.WriteLine("Opcion 1");
                Console.WriteLine("Imprime en pantalla todos los elementos del vector.");
                Console.WriteLine("");
                Console.WriteLine("Opcion 2");
                Console.WriteLine("ingresa un número y el programa busca si este se encuentra en el vector. Si lo encuentra, se indicara la posición en la que se encuentra.");
                Console.WriteLine("");
                Console.WriteLine("Opcion 3");
                Console.WriteLine("Se ordena el vector de forma ascendente o descendente, según la elección del usuario.");
                Console.WriteLine("");
                Console.WriteLine("Opcion 4");
                Console.WriteLine("Termina la ejecución del programa.");
                Console.WriteLine("------------------------------");
                Console.WriteLine("elija una opcion");
                int opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        for (int i = 0; i < tamaño; i++)
                        {
                            Console.WriteLine("Vector " + 1 + losVector[i]);
                        }
                        break;
                        
                    case 2:
                        Console.WriteLine("ingrese un número");
                        int num = int.Parse(Console.ReadLine());
                        for (int i = 0; i < tamaño; i++)
                        {
                            if (num == losVector[i])
                            {
                                Console.WriteLine("el vector " + num + " se encuentra en la posicion " + (i + 1));
                            }
                            else
                            {
                                Console.WriteLine("el vector " + num + " no se encuentra en la lista");
                            }
                        }
                        break;
                    
                    case 3:
                        bool bucle = true;
                        int guarda;
                        string respuesta1 = "ascendente";
                        string respuesta2 = "descendente";
                        while (bucle)
                        {
                            Console.WriteLine("de que forma quiere que se ordene el vector ascendente o descendente?");
                            string respuesta = Console.ReadLine();
                            if (respuesta == respuesta1)
                            {
                                bucle = false;
                                for (int i = 0; i < tamaño; i++)
                                {
                                    for (int t = 0; t < tamaño - 1; t++)
                                    {
                                        if (losVector[t] < losVector[t + 1])
                                        {
                                            guarda = losVector[t];
                                            losVector[t] = losVector[t + 1];
                                            losVector[t + 1] = guarda;

                                        }
                                    }
                                }
                                for (int i = 0; i < tamaño; i++)
                                {
                                    Console.WriteLine(losVector[i]);
                                }
                            }
                            else if (respuesta == respuesta2)
                            {
                                bucle = false;
                                for (int i = 0; i < tamaño; i++)
                                {
                                    for (int t = 0; t < tamaño - 1; t++)
                                    {
                                        if (losVector[t] > losVector[t + 1])
                                        {
                                            guarda = losVector[t];
                                            losVector[t] = losVector[t + 1];
                                            losVector[t + 1] = guarda;
                                        }
                                    }
                                }
                                for (int i = 0; i < tamaño; i++)
                                {
                                    Console.WriteLine(losVector[i]);
                                }
                            }
                            else
                            {
                                bucle = true;
                            }
                        }
                        break;
                    case 4:

                        bucle2 = false;
                        break;
                }
                
            }
            Console.ReadKey();
        }
    }
}
