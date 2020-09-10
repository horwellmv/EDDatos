using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea11
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            Console.WriteLine("Introduzca un número entero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca otro número entero: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1>num2)
            {
                Console.WriteLine(num1+" es mayor que "+num2);
            }
            else
            {
                Console.WriteLine(num2 + " es mayor que " + num1);
            }
            Console.ReadLine();
        }
    }
}
