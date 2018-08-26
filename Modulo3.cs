using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo3
{
    class Program
    {
        static void Main(string[] args)
        {

            /*PUNTO 1 - Crea un programa que pida al usuario su identificador y su contraseña (ambos
            numéricos), y no le permita seguir hasta que introduzca como identificador "1234" y como contraseña "1111". */

            int IDvalido = 1234;
            int passvalido = 1111;
            int ID;
            int pass;

            Console.WriteLine("BIENVENIDO!");

            do
            {
                Console.Write("Ingrese su identificador: ");
                ID = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingrese su contraseña: ");
                pass = Convert.ToInt32(Console.ReadLine());

                if (ID == 1234 && pass == 1111)
                {
                    Console.WriteLine("ACCESO CORRECTO... Bienvenido!");
                }

                else
                {
                    Console.WriteLine("ACCESO DENEGADO... Credenciales incorrectas");
                }
            }
            while (ID != IDvalido && pass != passvalido);

            /*PUNTO 2 -Crea un programa calcule cuantas cifras tiene un número entero positivo (pista: se
            puede hacer dividiendo varias veces entre 10).-*/

            int num, dig = 0;
            Console.Write("Bienvenido! Ingrese un número positivo: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num <= 0)
            {
                Console.WriteLine("ERROR!Ingerse otro número nuevamente: ");
            }

            else
            {
                do
                {
                    num = num / 10;
                    dig = dig + 1;
                }
                while (num > 0);
                Console.WriteLine("El número tiene " + dig + " dígitos..");
                Console.ReadKey();
            }

            /*PUNTO 3 -Crea un programa que muestre la tabla de multiplicar del 9.- */
            int resultado, numero = 9;
            Console.WriteLine("\n BIENVENIDO A LA TABLA DEL 9 \n");

            for (int i = 1; i <= 10; i++)
            {
                resultado = numero * i;
                Console.WriteLine(numero + " * " + i + " = " + resultado);
            }

            /*PUNTO 4 -Crea un programa que contenga un bucle sin fin que muestre los números enteros positivos a partir del uno.- */
            int lista;
            Console.WriteLine("BIENVENIDO A LA LISTA DE NÚMEROS SIN FIN\n");
            Console.WriteLine("Para salir del bucle infinito, presione CTRL+C");
            Console.WriteLine("Presione cualquier tecla para continuar: ");
            Console.ReadKey();

            lista = 1;
            do
            {
                Console.WriteLine(lista);
                lista = lista + 1;
            }

            while (lista > 0);

            /*PUNTO 5 -Crea un programa que contenga un bucle sin fin que escriba "Hola " en pantalla, sin avanzar de línea.-*/
            int pal;
            Console.WriteLine("\nBIENVENIDO A LA LISTA DE -HOLA- SIN FIN\n");
            Console.WriteLine("Para salir del bucle infinito, presione CTRL+C");
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            pal = 1;

            while (pal == 1)
                Console.Write("hola ");
            Console.ReadKey();

            /*PUNTO 6 -¿Cuál sería el resultado de las siguientes operaciones? a=5; b=++a; c=a++; b=b*5; a=a*2; Crea un programa que lo resuelva.-*/
            int a, b, c, a1, b1;
            Console.WriteLine("BIENVENIDO, Vamos a realizar unas operaciones...");
            Console.WriteLine("\na) a = 5 \nb) b = ++a \nc) c = a++ \nd) b = b*5 \ne) a = a*2\n");

            a = 5;
            b = 6;
            c = 6;
            b1 = b * 5;
            a1 = a * 2;

            Console.WriteLine("Resultados: \na) = " + a + "\nb) = " + b + "\nc) = " + c + "\nd) = " + b1 + "\ne) = " + a1);

            //PUNTO 8 -Crea un programa que pida una letra al usuario y diga si se trata de una vocal.-

            string letra;
            Console.Write("Bienvenido! Ingrese una letra: ");
            letra = Convert.ToString(Console.ReadLine());

            if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
            {
                Console.WriteLine("LA LETRA INGRESADA ES UNA VOCAL!");

            }

            else
            {
                Console.WriteLine("LA LETRA INGRESADA NO ES UNA VOCAL!");
            }

            /*PUNTO 9 -Crear un programa que pida al usuario un nombre y una contraseña. La contraseña se
            debe introducir dos veces. Si las dos contraseñas no son iguales, se avisará al usuario y se le
            volverán a pedir las dos contraseñas.- */

            string passw, nombre, pass2;

            Console.Write("Ingrese su nombre: ");
            nombre = Convert.ToString(Console.ReadLine());

            do
            {
                Console.Write("Ingrese su contraseña: ");
                passw = Convert.ToString(Console.ReadLine());

                Console.Write("Ingrese su contraseña nuevamente: ");
                pass2 = Convert.ToString(Console.ReadLine());

                if (passw != pass2)
                {
                    Console.WriteLine("Las contraseñas no coinciden, intentelo nuevamente.");
                }

                else
                {

                    Console.WriteLine("Contraseña correcta. BIENVENIDO..");
                }
            }

            while (passw != pass2);


            //PUNTO 10 - Crear un programa que pida al usuario su nombre, y le diga "Hola" si se llama "Martín", o bien le diga "No te conozco" si teclea otro nombre.

            string nom;

            Console.Write("Ingrese su nombre: ");
            nom = Convert.ToString(Console.ReadLine());

            if (nom != "Martin")
            {
                Console.WriteLine("No te conozco");
            }

            else
            {
                Console.WriteLine("Hola");
            }
        }
    }
}
