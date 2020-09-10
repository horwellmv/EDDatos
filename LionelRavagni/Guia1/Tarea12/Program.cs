using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea12
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            float resultado;
            Console.WriteLine("Introduzca un número entero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca otro número entero: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num2==0)
            {
                Console.WriteLine("Error No se puede dividir por cero.");
            }
            else
            {
                resultado = (float)num1/num2;
                Console.WriteLine(num2 + "/" + num1+" = "+resultado);
            }
            Console.ReadLine();
        }
    }
}
