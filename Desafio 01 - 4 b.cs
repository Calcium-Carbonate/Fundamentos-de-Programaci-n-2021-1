using System;

namespace Desafio_01___4_b
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.Write("Ingrese y: ");
			double y = double.Parse(Console.ReadLine());

			// Entrada del usuario de la variable 
			Console.Write("Ingrese d en grados: ");
			double d = double.Parse(Console.ReadLine());

			// Entrada del usuario de la variable 
			Console.Write("Ingrese b en grados: ");
			double b = double.Parse(Console.ReadLine());

			double e = 180 - (d + b);

			//c por angulos suplementarios

			double c = 180 - e;
			//  c  en radianes para realizar operaciones trigonometricas

			double cR = c * Math.PI / 180;

			//valor de z

			double z = Math.Tan(cR) * y;


			Console.WriteLine("El valor de z =   " + z);
		}
    }
}
