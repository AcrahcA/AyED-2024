using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Charca_VueltaAClases
{
    class Program
    {
        static void Main(string[] args)
        {
            int notaTotalPrueba = 0;
            int puedeAprobar = 0;
            int porcentaje = 0;
            Console.WriteLine("ingrese la cantidad de pruebas");
            int pruebas = int.Parse(Console.ReadLine());
            Console.WriteLine("ingresa la cantidad de tps");
            int tp = int.Parse(Console.ReadLine());
            int[] lasPruebas = new int[pruebas];
            int[] losTps = new int[tp];
            for (int i = 0; i < pruebas; i++)
            {
                Console.WriteLine("ingresa la nota que saco en la prueba " + (i + 1));
                int nota = int.Parse(Console.ReadLine());
                lasPruebas[i] = nota;
            }
            for (int i = 0; i < pruebas; i++)
            {
                notaTotalPrueba = notaTotalPrueba + lasPruebas[i];
            }
            for (int i = 0; i < tp; i++)
            {
                Console.WriteLine("ingresa la nota que saco en el tp " + (i + 1));
                int nota = int.Parse(Console.ReadLine());
                losTps[i] = nota;
                if (losTps[i] >= 6)
                {
                    porcentaje++;
                }
            }
            puedeAprobar =(int)(0.75*tp);
            if ((notaTotalPrueba) >= 6 && porcentaje >= (puedeAprobar))
            {
                Console.WriteLine("Aprobaron");
            }
            else 
            {
                Console.WriteLine("no pueden aprobar");
            }
            Console.ReadKey();

        }
    }
}
