using System;

namespace Desafio_02___03_sln_triangulos
{
    class Program
    {
        static void Main(string[] args)
        {
			// Entrada del usuario de la variable c
			Console.Write("Ingrese el valor de c en grados: ");
			double c = double.Parse(Console.ReadLine());

			// Entrada del usuario de la variable z
			Console.Write("Ingrese z: ");
			double z = double.Parse(Console.ReadLine());

			//convertidos c a radianes 

			double cR = c * (Math.PI / 180);

			double a = 180 - (90 + c);

			double t = z / Math.Sin(cR);

			double y = Math.Sqrt((t * t) - (z * z));

			//salidas
			Console.WriteLine("El valor del ángulo a es = " + a + " grados");
			Console.WriteLine("El valor de la hipotenusa es = " + t);
			Console.WriteLine("El valor de Y es = " + y);
		
		//video solución https://youtu.be/Kcdbt3Mj3RM

		}
	}
}
