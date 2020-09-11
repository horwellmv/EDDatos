using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace tarea10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable para el INPUT

            int entero;

            Console.WriteLine("ingrese el numero entero");

            entero = Convert.ToInt32(Console.ReadLine());

            //generar variable para el IF 

            int operacion = 2;
           
            if (entero % operacion == 0)
            {
                Console.WriteLine("Es Par");
            }
            else
            { 
                Console.WriteLine("Es Impar");

            }

            Console.ReadLine();

        }
    }
}
