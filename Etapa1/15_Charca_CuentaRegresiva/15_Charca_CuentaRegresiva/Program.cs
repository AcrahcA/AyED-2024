using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Charca_CuentaRegresiva
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dame un numero positivo");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------");
            for (int i = 0; i < num + 1; i++)
            {
                Console.WriteLine(num-i);
            }
            
            Console.ReadKey();
        }
    }
}
