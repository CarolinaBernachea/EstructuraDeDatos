using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidarAsistencia
{
	class Program
	{
		public static Boolean ValidaAsistencia(int n1, int n2)
		{
			Double Promedio = 0;
			Promedio = n1 * 0.75;

			if (n2 >= Promedio)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		static void Main(string[] args)
		{
			int num1;
			int num2;
			Console.WriteLine("SISTEMA DE VALIDACION DE ASISTENCIAS\n");

			Console.Write("Ingrese cantidad de clases: ");
			num1 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Ingrese asistencias: ");
			num2 = Convert.ToInt32(Console.ReadLine());

			if (ValidaAsistencia(num1, num2))
			{
				Console.WriteLine("\nNo estás libre. Seguí así!");
			}
			else
			{
				Console.WriteLine("\nTe quedaste libre. Nos vemos el año que viene =(.");
			}
		}
	}
}
