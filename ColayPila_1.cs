using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaColayPila
{
	class ColayPila_1
	{
		static void Main(string[] args)
		{
			//Ejercicio 1
			double n1;
			double n2;
			double n3;
			double n4;
			double n5;  // declaro variable double


			Console.WriteLine("BIENVENIDOS A QUEUE: ");
			Console.WriteLine("Ingrese 5 numeros reales de doble precisión\n");

			Console.Write("\n1er N°: ");
			n1 = Convert.ToDouble(Console.ReadLine());
			Console.Write("2do N°: ");
			n2 = Convert.ToDouble(Console.ReadLine());
			Console.Write("3er N°: ");
			n3 = Convert.ToDouble(Console.ReadLine());
			Console.Write("4to N°: ");
			n4 = Convert.ToDouble(Console.ReadLine());
			Console.Write("5to N°: ");
			n5 = Convert.ToDouble(Console.ReadLine());

			System.Collections.Queue miColaNumeros = new System.Collections.Queue(); //Declaro una cola que se llama miColaNumeros
			//Elementos de la cola, que los esta ENCOLANDO. Por ende, el primero que entra es el primero que sale.

			miColaNumeros.Enqueue(n1);
			miColaNumeros.Enqueue(n2);
			miColaNumeros.Enqueue(n3);
			miColaNumeros.Enqueue(n4);
			miColaNumeros.Enqueue(n5);

			foreach(object obj in miColaNumeros)

			{
				Console.WriteLine(obj);  //Printea de a uno lo que va desencolando.  
			}

			Console.ReadKey();

		}
	}
}
