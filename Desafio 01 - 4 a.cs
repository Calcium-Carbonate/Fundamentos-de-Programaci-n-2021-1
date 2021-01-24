using System;

namespace Desafio_01___4
{
    class Program
    {
        static void Main(string[] args)
        {
			// Entrada del usuario de la variable z
			Console.Write("Ingrese Z: ");
			double z = double.Parse(Console.ReadLine());

			// Entrada del usuario de la variable y
			Console.Write("Ingrese Y: ");
			double y = double.Parse(Console.ReadLine());

			// Entrada del usuario de la variable y
			Console.Write("Ingrese b en grados: ");
			double b = double.Parse(Console.ReadLine());



			double a = Math.Atan(y / z);
			// a en grados, resultado que nos interesa
			double ag = a * (180 / Math.PI);

			double c = 180 - (90 + ag);

			//valor de e por angulos suplementarios

			double e = 180 - c;

			double d = 180 - (b + e);
			// Necesitamos d en radianes

			double dR = d * (Math.PI / 180);


			double x = z / Math.Tan(dR) - y;

			//Asegurarse si dan los valores

			Console.WriteLine("El valor de x =   " + x );
			



		}
	}
}
