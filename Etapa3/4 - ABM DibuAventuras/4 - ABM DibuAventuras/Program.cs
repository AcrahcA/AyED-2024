using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4___ABM_DibuAventuras
{
    class Program
    {
        static string[,] lista = new string[20, 5];
        static int cantidad = 0;
        static int fila = 0;
        static void Main(string[] args)
        {
            bool bucle = true;
            while (bucle)
            {
                Menu();
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        NuevoPersonaje();
                        break;
                    case 2:
                        ConsultaPersonaje();
                        break;
                    case 3:
                        ModificarPersonaje();
                        break;
                    case 4:
                        EliminarPersonaje();
                        break;
                    case 5:
                        ListaDePersonajes();
                        object continuar = Console.ReadLine();
                        break;
                    case 6:
                        bucle = false;
                        break;
                }

            }
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("cantidad de personajes: " + cantidad + "/20");
            Console.WriteLine("---------------------------Menú--------------------");
            Console.WriteLine("1. Nuevo Personaje");
            Console.WriteLine("2. Consultar Personaje");
            Console.WriteLine("3. Modificar Personaje");
            Console.WriteLine("4. Eliminar Personaje");
            Console.WriteLine("5. Mostrar todos los personajes");
            Console.WriteLine("0. Salir");
            Console.WriteLine("---------------------------------------------------");
            Console.Write("Seleccione una opción: ");
        }
        static void NuevoPersonaje()
        {
            Console.Write("ingrese el nombre del perosnaje: ");
            string nombre = Console.ReadLine();
            Console.Write("ingrese el nombre de la serie a la que pertenece: ");
            string serie = Console.ReadLine();
            Console.Write("ingrese la cantidad de fuerza del personaje: ");
            int fuerza = int.Parse(Console.ReadLine());
            Console.Write("ingrese la cantidad de defensa del personaje: ");
            int defensa = int.Parse(Console.ReadLine());
            Console.Write("indique si tu personaje es un heroe, ingrese true si es heroe, ingrese false si no lo es: ");
            string heroe = Console.ReadLine();

            lista[cantidad, 0] = nombre;
            lista[cantidad, 1] = serie;
            lista[cantidad, 2] = fuerza.ToString();
            lista[cantidad, 3] = defensa.ToString();
            lista[cantidad, 4] = heroe;
            cantidad++;
            object continuar = Console.ReadLine();
        }
        static void ConsultaPersonaje()
        {
            Console.Write("ingrese el nombre del personaje que desea buscar: ");
            string busqueda = Console.ReadLine();
            Console.WriteLine("fila " + "\t" + "Nombre " + "\t" + "serie " + "\t" + "fuerza " + "\t" + "defenza " + "heroe ");
            for (int i = 0; i < cantidad; i++)
            {
                if (busqueda.Equals(lista[i, 0]))
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.Write(lista[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
            object continuar = Console.ReadLine();
        }
        static void ListaDePersonajes()
        {
            Console.WriteLine("fila " + "\t" +"Nombre " + "\t" + "serie " + "\t" + "fuerza " + "\t" + "defenza " + "heroe ");
            for(int i = 0; i< cantidad; i++)
            {
                Console.Write(i + "\t");
                for (int j = 0; j< 5; j++)
                {
                    Console.Write(lista[i,j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void ModificarPersonaje()
        {
            ListaDePersonajes();
            Console.WriteLine();
            Console.Write("ingrese la fila del personaje que desee modificar la fuerza y defenza: ");
            fila = int.Parse(Console.ReadLine());
            if (fila < cantidad)
            {
                Console.Write("Ingrese la nueva fuerza del personaje: ");
                int NewFuerza = int.Parse(Console.ReadLine());
                lista[fila, 2] = NewFuerza.ToString();
                Console.Write("Ingrese la nueva defenza del personaje: ");
                int NewDefenza = int.Parse(Console.ReadLine());
                lista[fila, 3] = NewDefenza.ToString();
                object continuar = Console.ReadLine();

            }
            else
            {
                Console.WriteLine("la fila no existe");
            }
        }
        static void EliminarPersonaje()
        {
            ListaDePersonajes();
            Console.Write("Ingrese la fila del personaje que desea eliminar: ");
            int filaEliminar = int.Parse(Console.ReadLine());

            if (filaEliminar < cantidad && filaEliminar >= 0)
            {
                for (int i = filaEliminar; i < cantidad - 1; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        lista[i, j] = lista[i + 1, j]; //rellenar la fila vacia
                    }
                }
                // eliminar la ultima fila
                for (int j = 0; j < 5; j++)
                {
                    lista[cantidad - 1, j] = null;
                }

                cantidad--;
                Console.WriteLine("Personaje fue eliminado con exito");
            }
            else
            {
                Console.WriteLine("Fila no válida.");
            }
            object continuar = Console.ReadLine();
        }

    }
}
