using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea13
{
    class Program
    {
        static void Main(string[] args)
        {
            //SOLICITAR PRIMER ENTERO

            int primerentero;

            Console.WriteLine("ingrese el numero entero");

            primerentero = Convert.ToInt32(Console.ReadLine());


            //SOLICITAR SEGUNDO ENTERO 

            int segundoentero;

            Console.WriteLine("ingrese el segundo numero entero");

            segundoentero = Convert.ToInt32(Console.ReadLine());




            //PRIMERA VARIABLE IF 


            if (segundoentero > 0)
            {
                Console.WriteLine("el resultado de la division es: " + primerentero / segundoentero);

            }
            else
                Console.WriteLine("Error: No se puede dividir entre cero");
            {

            }

            Console.ReadLine();
        }
    }
}
