using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            int id, password;
            id = 1234;
            password = 1111;
            Console.WriteLine("Ingrese su numero identificador: ");
            id = Convert.ToInt32(Console.ReadLine());
            while (id!=1234)
            {
                Console.WriteLine("Identificador incorrecto. Vuelva a ingresarlo: ");
                id = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Ingrese su contraseña: ");
            password = Convert.ToInt32(Console.ReadLine());
            while (password != 1111)
            {
                Console.WriteLine("Contraseña incorrecta. Vuelva a ingresarla: ");
                password = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("¡Identificación validada!");
            Console.ReadKey();
        }
    }
}
