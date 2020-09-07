using System;
using System.Threading;

namespace EzequielQuispe
{
    class Program
    {
        static void Main(string[] args)
        {
            Tarea tarea = new Tarea();
            tarea.Ejercicio_5();
            /*
            tarea.Ejercicio_2();
            tarea.Ejercicio_3();
            tarea.Ejercicio_4();
            tarea.Ejercicio_5();
            tarea.Ejercicio_6();
            tarea.Ejercicio_7();
            tarea.Ejercicio_8();
            tarea.Ejercicio_9();
            tarea.Ejercicio_10();
            */
        }

    }

    class Tarea
    {
        public void Ejercicio_1()
        {
            int usuario, contraseña;

            do
            {
                Console.WriteLine("Ingresa tu usuario:");
                usuario = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingresar tu contraseña:");
                contraseña = Convert.ToInt32(Console.ReadLine());
            }

            while (usuario != 1234 || contraseña != 1111);
            Console.WriteLine("Correcto");
            Console.ReadLine();
        }

        public void Ejercicio_2()
        {
            int numero, cantidadCifras;
            string numeroNuevo;

            Console.WriteLine("Ingresá un número:");
            numero = Convert.ToInt32(Console.ReadLine());
            numeroNuevo = Convert.ToString(numero);

            cantidadCifras = numeroNuevo.Length;

            Console.WriteLine($"El número tiene {cantidadCifras} cifras");
            Console.ReadLine();
        }

        public void Ejercicio_3()
        {
            int multiplicar = 9;
            int resultado;

            for (int i = 1; i <= 10; i++)
            {
                resultado = multiplicar * i;
                Console.WriteLine($"{multiplicar} x {i} = {resultado}");
            }
            Console.ReadLine();
        }

        public void Ejercicio_4()
        {
            int infinito = 1;

            while (1 == 1)
            {
                Console.WriteLine(infinito);
                Thread.Sleep(100);
                infinito++;
            }
        }

        public void Ejercicio_5()
        {
            string infinito = "Hola";

            while (1 == 1)
            {
                Console.Write(infinito);
                Thread.Sleep(100);
            }
        }

        public void Ejercicio_6()
        {
            int a = 5;
            int b = ++a;
            int c = a++;

            Console.WriteLine("b: " + b + "\nc: " + c);

            b = b * 5;
            a = a * 2;

            Console.WriteLine("b: " + b + "\na: " + a);
            Console.ReadLine();
        }

        public void Ejercicio_7()
        {
            int a = 5;
            int b = a + 2;
            int c = -3;

            Console.WriteLine("b: " + b);

            b -= 3;
            c *= 2;


            Console.WriteLine("b: " + b + "\nc: " + c);

            ++c;
            a *= b;

            Console.WriteLine("c: " + c + "\na: " + a);
            Console.ReadLine();
        }

        public void Ejercicio_8()
        {
            char vocal;

            Console.WriteLine("Ingresá una letra:");
            vocal = Convert.ToChar(Console.ReadLine());

            if (vocal == 'a' || vocal == 'e' || vocal == 'i' || vocal == 'o' || vocal == 'u')
            {
                Console.WriteLine("Es una vocal.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("No es una vocal.");
                Console.ReadLine();
            }
        }

        public void Ejercicio_9()
        {
            string usuario;
            int primerContraseña, segundaContraseña;
            bool ingresoCorrecto = false;

            Console.WriteLine("Ingresa un usuario:");
            usuario = Console.ReadLine();

            do
            {
                Console.WriteLine("Ingresa una contraseña:");
                primerContraseña = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Volvé a ingresar la contraseña:");
                segundaContraseña = Convert.ToInt32(Console.ReadLine());

                if (primerContraseña == segundaContraseña)
                {
                    Console.WriteLine("Las contraseñas coinciden.");
                    Console.ReadLine();
                    ingresoCorrecto = true;
                }
                else
                {
                    Console.WriteLine("Las contraseñas no coinciden, volvé a intentarlo.");
                }

            } while (ingresoCorrecto == false);
        }

        public void Ejercicio_10()
        {
            string usuario = "Martín";
            string nombre;

            Console.WriteLine("Ingresa tu nombre:");
            nombre = Console.ReadLine();

            if (nombre == usuario)
            {
                Console.WriteLine("Hola.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("No te conozco.");
                Console.ReadLine();
            }
        }
    }
}
