using System;

namespace Desafio_02___2_sln_triangulos
{
    class Program
    {
        static void Main(string[] args)
        {
			// Entrada del usuario de la variable t
			Console.Write("Ingrese t: ");
			double t = double.Parse(Console.ReadLine());

			// Entrada del usuario de la variable a
			Console.Write("Ingrese a: ");
			double a = double.Parse(Console.ReadLine());

			double aR= a * (Math.PI/180);

			double c = 180 - (90 + a);

			double y = t * Math.Cos(aR);

			double x = t * Math.Sin(aR);

			Console.WriteLine("El valor de c es =  " + c + "  grados" ) ;
			Console.WriteLine("El valor de y es =  " + y  ) ;
			Console.WriteLine("El valor dex  es =  " + x  ) ;


			
		}
	}
}
