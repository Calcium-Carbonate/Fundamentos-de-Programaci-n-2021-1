﻿using System;

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
			Console.Write("Ingrese a en grados: ");
			double a = double.Parse(Console.ReadLine());

			double aR= a * (Math.PI/180);

			double c = 180 - (90 + a);

			double z = t * Math.Cos(aR);

			double y = t * Math.Sin(aR);

			Console.WriteLine("El valor de c es =  " + c + "  grados" ) ;
			Console.WriteLine("El valor de y es =  " + y  ) ;
			Console.WriteLine("El valor de z  es =  " + z  ) ;

		//video solución https://youtu.be/Kcdbt3Mj3RM
			
		}
	}
}
