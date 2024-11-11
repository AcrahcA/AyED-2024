using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pochimon2
{
    class Program
    {
        static int cantidad = 0;
        static int fila = 0;
        static Object[,] pochimon = new Object[75, 7];
        static void Main(string[] args)
        {
            bool bucle = true;

            while (bucle)
            {
                MostrarMenu();
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        RegistrarPochimon();
                        break;
                    case 2:
                        AsignarInvestigador();
                        break;
                    case 3:
                        ActualizarNivel();
                        break;
                    case 4:
                        MarcarInvestigado();
                        break;
                    case 5:
                        MostrarInformacion();
                        break;
                    case 6:
                        BuscarPorTipo();
                        break;
                    case 7:
                        MostrarPorInvestigador();
                        break;
                    case 8:
                        MostrarPochimonsPicados();
                        break;
                    case 9:
                        bucle = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            }


        }
        static void MostrarMenu()
        {
            Console.Clear();
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
        }

        static void RegistrarPochimon()
        {
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
            }
            else
            {
                Console.WriteLine("la cantidad maxima para registrar pochimones es de 75");
            }
        }

        static void AsignarInvestigador()
        {
            MostrarTablaPochimons();
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
                Console.WriteLine("la fila no existe");
            }
        }

        static void ActualizarNivel()
        {
            MostrarTablaPochimons();
            Console.Write("Ingrese la fila del Pochimon que desea mejorar: ");
            fila = int.Parse(Console.ReadLine());
            if (fila < cantidad)
            {
                Random random = new Random();
                int nivelActual = int.Parse(pochimon[fila, 3].ToString());
                pochimon[fila, 3] = nivelActual + random.Next(1, 3);
                Console.WriteLine("El Pochimon " + pochimon[fila, 1] + " ha sido mejorado. Su nuevo nivel es: " + pochimon[fila, 3]);
            }
            else
            {
                Console.WriteLine("la fila no existe");
            }
            Object nada = Console.ReadLine();
            Console.Clear();
        }

        static void MarcarInvestigado()
        {
            MostrarTablaPochimons();
            Console.Write("Ingrese la fila del Pochimon a marcar como investigado: ");
            fila = int.Parse(Console.ReadLine());
            if (fila < cantidad)
            {
                if (0.Equals(pochimon[fila, 4]))
                {
                    pochimon[fila, 4] = 2;
                    Console.WriteLine("El Pochimon ha sido marcado como investigado.");
                }
            }
            else
            {
                Console.WriteLine("la fila no existe");
            }
            Console.WriteLine("se ha asignado al pochimon de la fila " + fila + " como investigado");
            Object nada6 = Console.ReadLine();
            Console.Clear();
        }

        static void MostrarInformacion()
        {
            Console.WriteLine("Lista de todos los Pochimons registrados:");
            MostrarTablaPochimons();
        }

        static void BuscarPorTipo()
        {
            Console.Write("Ingrese el tipo de Pochimon a buscar (A/F/P): ");
            string tipo = Console.ReadLine();
            for (int i = 0; i < cantidad; i++)
            {
                if (tipo.Equals(pochimon[i, 2]))
                {
                    for (int j = 0; j < 6; j++)
                    {
                        Console.Write(pochimon[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine("se ha asignado al pochimon de la fila " + fila + " como investigado");
            Object nada6 = Console.ReadLine();
            Console.Clear();
        }

        static void MostrarPorInvestigador()
        {
            Console.Write("Ingrese el código del investigador: ");
            Object investigador = Console.ReadLine();
            for (int i = 0; i < cantidad; i++)
            {
                if (investigador.Equals(pochimon[i, 5]))
                {
                    for (int j = 0; j < 6; j++)
                    {
                        Console.Write(pochimon[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
        }

        static void MostrarPochimonsPicados()
        {
            Console.WriteLine("Pochimons con un nivel mayor a 30:");
            for (int i = 0; i < cantidad; i++)
            {
                int nivel = int.Parse(pochimon[i, 3].ToString());
                if (nivel > 30)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        Console.Write(pochimon[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
        }

        static void MostrarTablaPochimons()
        {
            Console.WriteLine("| Fila | Nombre | Tipo | Nivel | Estado | Investigador Asignado |");
            for (int i = 0; i < cantidad; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(pochimon[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}

