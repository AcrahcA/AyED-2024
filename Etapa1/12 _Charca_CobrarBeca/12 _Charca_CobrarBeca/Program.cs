﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12__Charca_CobrarBeca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cuantos años tiene");
            int edad = int.Parse(Console.ReadLine());

            if (edad <= 19)
            {
                Console.WriteLine("de cuanto son tus ingresos");
                int ingresos = int.Parse(Console.ReadLine());
                if (ingresos >= 100000)
                {
                    Console.WriteLine("podes cobrar");
                }
                else
                {
                    Console.WriteLine("no podes cobrar");
                }
            }
            else
            {
                Console.WriteLine("no puedes cobrar por ser menor de 19 años");
            }
            Console.ReadKey();
        }
    }
}
