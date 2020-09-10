using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int resultado;
            Console.WriteLine("Introduzca un número: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca otro número: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            resultado = num1 * num2;
            Console.WriteLine(num1 + " x " + num2 + " = " + resultado);
            Console.ReadLine();
        }
    }
}
