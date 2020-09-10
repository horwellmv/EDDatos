using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea15
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 1;
            do 
            {
                Console.WriteLine(numero);
                numero++;
            } while (numero >=1 && numero <=10);
            Console.ReadLine();
        }
    }
}
