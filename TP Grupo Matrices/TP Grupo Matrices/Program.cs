using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Grupo_Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad = 0;
            int fila = 0;
            bool bucle = true;
            Object[,] pochimon = new object[75, 7];

            while (bucle)
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Menú Principal - Centro de Investigación de Pochimons");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Pochimones Encontrados: " + cantidad + "/75");
                Console.WriteLine("");
                Console.WriteLine("1. Registrar Pochimon");
                Console.WriteLine("2. Asignar Investigador a Pochimon");
                Console.WriteLine("3. Actualizar Nivel de Pochimon");
                Console.WriteLine("4. Marcar Pochimon como Investigado");
                Console.WriteLine("5. Mostrar Información de Pochimons");
                Console.WriteLine("6. Buscar Pochimons por Tipo");
                Console.WriteLine("7. Mostrar Pochimons por Investigador");
                Console.WriteLine("8. Mostrar Pochimons Picados");
                Console.WriteLine("9. Salir");
                Console.WriteLine("--------------------------------------------------");
                Console.Write("Ingrese la opción deseada: ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        if (cantidad < 75)
                        {
                            Console.Write("Ingrese el nombre del Pochimon: ");
                            Object nombre = Console.ReadLine();
                            Console.Write("Ingrese el tipo del Pochimon (A/F/P): ");
                            Object tipo = Console.ReadLine();
                            Console.Write("Ingrese el nivel del Pochimon: ");
                            String nivel = Console.ReadLine();
                            pochimon[cantidad, 0] = cantidad;
                            pochimon[cantidad, 1] = nombre;
                            pochimon[cantidad, 2] = tipo;
                            pochimon[cantidad, 3] = nivel;
                            pochimon[cantidad, 4] = 0;
                            pochimon[cantidad, 5] = 0;
                            Console.WriteLine("El Pochimon se ha registrado.");
                            cantidad++;
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("Capacidad máxima de Pochimons alcanzada (75).");
                        }
                        break;

                    case 2:
                        Console.WriteLine("| Fila| Nombre |Tipo |Nivel |Estado |Investigador Asignado |");
                        Console.WriteLine();
                        for (int i = 0; i < cantidad; i++)
                        {
                            for (int j = 0; j < 6; j++)
                            {
                                pochimon[i, 0] = i;
                                Console.Write(pochimon[i, j] + "\t");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                        Console.Write("Ingrese la fila del Pochimon: ");
                        fila = int.Parse(Console.ReadLine());
                        if (fila < cantidad)
                        {
                            Console.Write("Ingrese el código del investigador: ");
                            Object numDeInvestigador = Console.ReadLine();
                            pochimon[fila, 5] = numDeInvestigador;
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("Fila no válida.");
                        }
                        Object nadaa = Console.ReadLine();
                        Console.Clear();
                        break;

                    case 3:
                        Console.WriteLine("| Fila | Nombre | Tipo | Nivel |");
                        Console.WriteLine();
                        for (int i = 0; i < cantidad; i++)
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                pochimon[i, 0] = i + 1;
                                Console.Write(pochimon[i, j] + "\t");
                            }
                            Console.WriteLine();
                        }
                        Console.Write("Ingrese la fila del Pochimon que desea mejorar: ");
                        fila = int.Parse(Console.ReadLine());
                        if (fila < cantidad)
                        {
                            Random random = new Random();
                            int nivelActual = int.Parse(pochimon[fila, 3].ToString());
                            pochimon[fila, 3] = nivelActual + random.Next(1, 3);
                            Console.WriteLine("El Pochimon " + pochimon[fila, 1] + " ha sido mejorado. Su nuevo nivel es: " + pochimon[fila, 3]);
                            Console.WriteLine("Presione Enter para continuar");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("no hay esa cantidad de fila");
                        }
                        Object nada = Console.ReadLine();
                        Console.Clear();
                        break;

                    case 4:
                        Console.WriteLine("| Fila| Nombre |Tipo |Nivel |Estado |Investigador Asignado |");
                        Console.WriteLine();
                        for (int i = 0; i < cantidad; i++)
                        {
                            for (int j = 0; j < 6; j++)
                            {
                                pochimon[i, 0] = i;
                                Console.Write(pochimon[i, j] + "\t");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                        Console.Write("Ingrese la fila del Pochimon a marcar como investigadco: ");
                        fila = int.Parse(Console.ReadLine());
                        if (fila < cantidad)
                        {
                            if (0.Equals(pochimon[fila, 4]))
                            {
                                pochimon[fila, 4] = 2;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Fila no válida.");
                        }
                        Console.WriteLine("se ha asignado al pochimon de la fila " + fila + " como investigado");
                        Object nada6 = Console.ReadLine();
                        Console.Clear();
                        break;

                    case 5:
                        Console.WriteLine("Lista de todos los Pochimons registrados:");
                        Console.WriteLine();
                        for (int i = 0; i < cantidad; i++)
                        {
                            for (int j = 0; j < 6; j++)
                            {
                                pochimon[i, 0] = i;
                                Console.Write(pochimon[i, j] + "\t");
                            }
                            Console.WriteLine();
                        }
                        Object nada1 = Console.ReadLine();
                        Console.Clear();
                        break;

                    case 6:
                        Console.Write("Ingrese el tipo de Pochimon a buscar (A/F/P): ");
                        string tipo2 = Console.ReadLine();
                        String tipo3 = tipo2.ToLower();

                        for (int i = 0; i < cantidad; i++)
                        {
                            if (tipo2.Equals(pochimon[i, 2]))
                            {
                                for (int j = 0; j < 6; j++)
                                {
                                    pochimon[i, 0] = i;
                                    Console.Write(pochimon[i, j] + "\t");
                                }
                                Console.WriteLine();
                            }
                            if (tipo3.Equals(pochimon[i, 2]))
                            {
                                for (int j = 0; j < 6; j++)
                                {
                                    pochimon[i, 0] = i;
                                    Console.Write(pochimon[i, j] + "\t");
                                }
                                Console.WriteLine();
                            }
                        }
                        Console.Write("presione enter para volver al menú");
                        Object Nada = Console.ReadLine();

                        Console.Clear();
                        break;

                    case 7:
                        Console.Write("Ingrese el código del investigador: ");
                        Object investigador2 = Console.ReadLine();
                        for (int i = 0; i < cantidad; i++)
                        {
                            if (investigador2.Equals(pochimon[i, 5]))
                            {
                                for (int j = 0; j < 6; j++)
                                {
                                    pochimon[i, 0] = i;
                                    Console.Write(pochimon[i, j] + "\t");
                                }
                                Console.WriteLine();
                            }
                        }
                        Object nada2 = Console.ReadLine();
                        Console.Clear();
                        break;

                    case 8:
                        Console.WriteLine("Pochimons con un nivel mayor a 30:");
                        for (int i = 0; i < cantidad; i++)
                        {
                            int nivel = int.Parse(pochimon[i, 3].ToString());
                            if (nivel > 30)
                            {
                                for (int j = 0; j < 6; j++)
                                {
                                    pochimon[i, 0] = i;
                                    Console.Write(pochimon[i, j] + "\t");
                                }
                                Console.WriteLine();
                            }
                        }
                        Object nada3 = Console.ReadLine();
                        Console.Clear();
                        break;

                    case 9:
                        bucle = false;
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}
