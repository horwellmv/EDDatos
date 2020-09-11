using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea11
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


            if (primerentero > segundoentero)
            {
                Console.WriteLine("El primer entero ingresado es igual a : " + primerentero + " y es el mayor");
            }
            else
            {
                Console.WriteLine("El segundo entero ingresado es igual a: " + segundoentero + " y es el mayor");
            }
                  
                Console.ReadLine(); 

        }
    }
}


