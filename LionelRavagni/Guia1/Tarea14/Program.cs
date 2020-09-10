using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea14
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 1;
            while (numero >= 1 && numero <= 10)
            {
                Console.WriteLine(numero);
                numero++;
            }
            Console.ReadLine();
        }
    }
}
