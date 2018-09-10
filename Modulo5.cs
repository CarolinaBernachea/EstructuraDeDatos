using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo5
{
	class Modulo5
	{  //Ejercicio 1 
		public static void Signo(float n)
		{
			if (n < 0)
			{

				Console.WriteLine("-1");

			}
			else if (n > 0)
			{
				Console.WriteLine("1");
			}
			else
			{
				Console.WriteLine("0");

			}
		}

		//Ejercicio 2
		public static void Menor(int n1, int n2)
		{
			if (n1 > n2)
			{
				Console.WriteLine(n1);
			}
			else
			{
				Console.WriteLine(n2);
			}
		}

		//Ejercicio 3
		public static void EsPrimo(int np)
		{
			bool esPrimo = false;
			if (np != 2)
			{
				for (int i = 2; i < np / 2; i++)
				{
					if (np % i == 0)
					{
						esPrimo = true;
						Console.WriteLine("\nEl número ingresado NO ES PRIMO!.");
						break;
					}
				}
			}
			if (!esPrimo)
			{
				{
					Console.WriteLine("\nEl número ingresado ES PRIMO!.");
				}
			}
		}

		//Ejercicio 5
		public static int CalculaSuma(int a, int b)
		{
			int suma = a + b;
			return suma;
		}

		public static int CalculaResta(int a, int b)
		{
			int resta = a - b;
			return resta;
		}

		public static int CalculaDivision(int a, int b)
		{
			int division = a / b;
			return division;
		}

		public static int CalculaMultiplicacion(int a, int b)
		{
			int multiplicacion = a * b;
			return multiplicacion;
		}

		//Ejercicio 6
		public static int SumarCifras(int num)
		{
			int acum = 0;
			while (num != 0)
			{
				int cifra = num % 10;
				acum += cifra;
				num = num / 10;
			}
			return acum;
		}

		//Ejercicio 7
		public static void Triangulo()
		{
			string Letra;

			string Letra = anchura;
			for (string linea = 0; linea < Letra; linea++)
			{
				for (int columna = 0; columna < anchura; columna++)
			{

			}
			}
		}


		


		public static void Main()
		{
			//Ejercicio 1
			float num;

			Console.WriteLine("BIENVENIDO A NUMEROS POSITIVOS, NEGATIVOS O CERO");

			Console.Write("Ingrese un número: ");
			num = Convert.ToInt32(Console.ReadLine());

			Signo(num);

			//Ejercicio 2
			int num1, num2;

			Console.WriteLine("\nBIENVENIDO A NÚMERO MAYOR!!\n");

			Console.Write("Ingrese el primer número: ");
			num1 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Ingrese el segundo número: ");
			num2 = Convert.ToInt32(Console.ReadLine());

			Menor(num1, num2);

			//Ejercicio 3
			int nprimo;

			Console.WriteLine("\nBIENVENIDO A NUMEROS PRIMOS!");

			Console.Write("Ingrese el número a identificar: ");
			nprimo = Convert.ToInt32(Console.ReadLine());

			EsPrimo(nprimo);

			//Ejercicio 5
			int valor1, valor2, opcion;

			Console.WriteLine("\nBienvenido a CALCULA.!\n");

			Console.WriteLine("Elija una opción: ");
			Console.Write("\n 1- Sumar\n 2- Restar\n 3- Multiplicar\n 4- Dividir\n");
			opcion = Convert.ToInt32(Console.ReadLine());

			Console.Write("Ingrese el primer número: ");
			valor1 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Ingrese el segundo valor: ");
			valor2 = Convert.ToInt32(Console.ReadLine());

			switch (opcion)
			{
				case 1:
					CalculaSuma(valor1, valor2);
					Console.WriteLine("\n El resultado de su operación es: {0}", CalculaSuma(valor1, valor2));
					break;
				case 2:
					CalculaResta(valor1, valor2);
					Console.WriteLine("\n El resultado de su operación es: {0}", CalculaResta(valor1, valor2));
					break;
				case 3:
					CalculaMultiplicacion(valor1, valor2);
					Console.WriteLine("\n El resultado de su operación es: {0}", CalculaMultiplicacion(valor1, valor2));
					break;
				case 4:
					CalculaDivision(valor1, valor2);
					Console.WriteLine("\n El resultado de su operación es: {0}", CalculaDivision(valor1, valor2));
					break;
				default:
					Console.WriteLine("Opción Inválida.");
					Console.ReadLine();
					break;
			}

			CalculaSuma(valor1, valor2);

			//Ejercicio 6
			int Num;
			Console.WriteLine("\nBIENVENIDO AL SUMADOR DE CIFRAS");

			Console.Write("Ingrese un número. (máx 9 cifras): ");
			Num = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("\nLa suma de la cifra ingresada es de: {0}", SumarCifras(Num));
			Console.ReadKey();

			//Ejercicio 7
			int numero; 
			string letra;

			Console.WriteLine("\nBIENVENIDO AL TRIANGULO: ");

			Console.Write("Ingrese la anchura del triángulo: ");
			numero = Convert.ToInt32(Console.ReadLine());
			Console.Write("Ingrese la letra del patrón: ");
			letra = Convert.ToString(Console.ReadLine());


		}
	}
}
