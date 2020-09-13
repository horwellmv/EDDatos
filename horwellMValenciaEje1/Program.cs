using System;

namespace horwellMValenciaEje1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Primer trabajo practico C#");
            //Console.ReadLine();

            string name = "Horwell Murillo Valencia.";
            Console.WriteLine(name);


            // 2. Suma de numeros 200 y 56
            float numero1 = 200;
            float numero2 = 56;

            Console.WriteLine(numero1 + numero2);

            // 3. Producto de numeros 13 y 12

            numero1 = 13;
            numero2 = 12;
            Console.WriteLine(numero1 * numero2);

            // 4. Diferencia de 321 y 213
            numero1 = 321;
            numero2 = 213;
            Console.WriteLine(numero1 - numero2);

            // 5. Calcular el resultado de(20 + 5) % 6
            numero1 = 20;
            numero2 = 5;
            Console.WriteLine((numero1 + numero2) / 6);


            // 6. Crea un programa que calcule el producto de los números 12 y 102, usando variables.
            numero1 = 102;
            numero2 = 12;
            Console.WriteLine(numero1 * numero2);

            // 7. Crea un programa que calcule la suma de 200 y 1111, usando variables.
            numero1 = 1111;
            numero2 = 200;
            Console.WriteLine(numero1 + numero2);

            // 8. Crea un programa que calcule el producto de los números 10 y 25, usando variables llamadas numero1 y numero2.
            numero1 = 10;
            numero2 = 25;
            Console.WriteLine(numero1 * numero2);

            // 9. Crea un programa que calcule el producto de dos números introducidos por el usuario.
            Console.WriteLine("Ingresa primer numero entero: ");
            float firstNumber = Convert.ToInt32(Console.ReadLine());
            numero1 = firstNumber;

            Console.WriteLine("Ingresa segundo numero entero: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            numero2 = secondNumber;

            Console.WriteLine("Resultado del producto es: " + (numero1 * numero2));
        }
    }
}
