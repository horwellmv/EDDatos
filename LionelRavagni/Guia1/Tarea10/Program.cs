using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea10
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Introduzca un número entero: ");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero%2==0)
            {
                Console.WriteLine("El numero ingresado es "+numero+" y es par.");
            }
            Console.ReadLine();
        }
    }
}
