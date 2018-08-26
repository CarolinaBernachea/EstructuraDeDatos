using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo2
{
    class Program
    {
        static void Main(string[] args)
        {

            /*PUNTO 2 -Crea un programa que diga el resultado de sumar 200 y 56.-*/
            Console.WriteLine("La suma 200 + 56 es igual a: ");
            Console.WriteLine(200 + 56);

            /*PUNTO 3 -Haz un programa que calcule el producto de los números 13 y 12.-*/
            Console.WriteLine("El producto de 13 x 12 es igual a: ");
            Console.WriteLine(13 * 12);

            /*PUNTO 4 -Un programa que calcule la diferencia (resta) entre 321 y 213-*/
            Console.WriteLine("La resta 321 - 213 es igual a: ");
            Console.WriteLine(321 - 213);

            /*PUNTO 5 -Calcular el resultado de (20+5) % 6-*/ 
            Console.WriteLine("5. El resultado de (20+5) % 6, es igual a: ");
            Console.WriteLine((20 + 5) % 6);

            /*PUNTO 6 -Crea un programa que calcule el producto de los números 12 y 102, usando variables.-*/
            int a = 12;
            int b = 102;

            Console.WriteLine("6. 12 * 102 es igual a: ");
            Console.WriteLine(a * b);

            /*PUNTO 7 -Crea un programa que calcule la suma de 200 y 1111, usando variables.-*/
            int c = 200;
            int d = 1111;

            Console.WriteLine("7. La suma de 200 + 1111 es igual a: ");
            Console.WriteLine(c + d);

            /*PUNTO 8 -Crea un programa que calcule el producto de los números 10 y 25, usando variables llamadas "numero1" y "numero2".-*/
            int numero1 = 10;
            int numero2 = 25;

            Console.WriteLine("8. El producto de 10 * 25 es igual a: ");
            Console.WriteLine(numero1 * numero2);

            /*PUNTO 9 -Crea un programa que calcule el producto de dos números introducidos por el usuario.-*/
            int num1, num2;

            Console.WriteLine("Bienvenido al multiplicador!");

            Console.Write("Ingrese el primer número: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El resultado de su multiplicación es de: ");
            Console.WriteLine(num1 * num2);

            /*PUNTO 10 -Crea un programa que pida al usuario un número entero y diga si es par.-*/
            int numero;
            Console.WriteLine("Bienvenido a NUMEROS PARES");
            Console.Write("Ingrese un número para saber si es par o no: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
                Console.WriteLine("El número es par.");
            else
                Console.WriteLine("El número no es par.");

            /*PUNTO 11 -Crea un programa que pida al usuario dos números enteros y diga cuál es el mayor de ellos.-*/
            int n1, n2;

            Console.WriteLine("Bienvenido a NUMEROS MAYORES");
            Console.Write("Ingrese el primer número: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2)
                Console.WriteLine("El número " + n1 + " es el mayor.");
            else
                Console.WriteLine("El número " + n2 + " es el mayor.");

            /*PUNTO 12 -Crea un programa que pida al usuario dos números enteros. Si el segundo no es cero, mostrará el resultado de dividir entre el primero y el segundo. 
            Por el contrario, si el segundo número es cero, escribirá "Error: No se puede dividir entre cero".-*/
            int n_1, n_2;
            Console.WriteLine("Bienvenido al divisor!");
            Console.Write("Ingrese primer número: ");
            n_1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese segundo número: ");
            n_2 = Convert.ToInt32(Console.ReadLine());

            if (n_2 != 0)
                Console.WriteLine(n_1 / n_2);
            else
                Console.WriteLine("ERROR! No se puede dividir entre cero.");

            /*PUNTO 13 -Crea un programa que pida un número del 1 al 5 al usuario, y escriba el nombre de ese número, usando "switch" 
            (por ejemplo, si introduce "1", el programa escribirá "uno").-*/
            int numswitch;

            Console.Write("Bienvenido al SWITCH, ingrese un número del 1 al 5: ");
            numswitch = Convert.ToInt32(Console.ReadLine());

            switch (numswitch)
            {
                case 1:
                    Console.WriteLine("Uno.");
                    break;
                case 2:
                    Console.WriteLine("Dos.");
                    break;
                case 3:
                    Console.WriteLine("Tres.");
                    break;
                case 4:
                    Console.WriteLine("Cuatro.");
                    break;
                case 5:
                    Console.WriteLine("Cinco.");
                    break;
                default:
                    Console.WriteLine("ERROR EN RANGO. El número debe ser del 1 al 5.");
                    break;
            }

            Console.ReadKey();

            /*PUNTO 14 -Crea un programa que escriba en pantalla los números del 1 al 10, usando "while".- */
            int n;
            Console.WriteLine("BIENVENIDO A LA LISTA DE NÚMEROS (WHILE)");
            n = 1;

            while (n < 11)
            {
                Console.WriteLine(n);
                n = n + 1;
            }

            /*PUNTO 15 -Crea un programa que escriba en pantalla los números del 1 al 10, usando "do..while".-*/
            int lista;
            Console.WriteLine("BIENVENIDO A LA LISTA DE NÚMEROS (DO WHILE)");
            lista = 1;

            do

            {
                Console.WriteLine(lista);
                lista = lista + 1;
            }

            while (lista <= 10);

            /*PUNTO 16 -Crea un programa que muestre los números del 10 al 20, ambos incluidos, usando “for”-*/
            Console.WriteLine("BIENVENIDO A LA LISTA DE NÚMEROS (FOR)");

            for (int i = 10; i <= 20; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
