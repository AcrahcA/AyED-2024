using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Charca_IngresePassword
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese la contraseña");
            String contraseña = Console.ReadLine();
            String contra = "ariel";
            if (contraseña == contra)
            {
                Console.WriteLine("contraseña correcta");
            }
            else
            {
                Console.WriteLine("contraseña incorrecta");

            }
            Console.ReadKey();
        }
    }
}
