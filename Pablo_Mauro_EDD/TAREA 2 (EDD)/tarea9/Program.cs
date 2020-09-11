using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea9
{
    class Program
    {
        static void Main(string[] args)
        {
            //PRIMER VALOR A MULTIPLICAR:

            byte primernumero;

            Console.WriteLine("ingresar el primer numero a multiplicar");
            primernumero = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Su valor ingresado es: " + primernumero);

            Console.ReadLine();

            //SEGUNDO VALOR A MULTIPLICAR:

            byte segundonumero;

            Console.WriteLine("ingresar el segundo numero a multiplicar");
            segundonumero = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Su valor ingresado es: " + segundonumero);

            Console.ReadLine();

            //PRODUCTO o RESULTADO:

            Console.WriteLine("EL resultado es: " + primernumero * segundonumero);

            Console.ReadLine();

        }
    }
}
