using System;

namespace Desafio_01___4_c
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese w: ");
            double w = double.Parse(Console.ReadLine());

            Console.Write("Ingrese x: ");
            double x = double.Parse(Console.ReadLine());


            Console.Write("Ingrese d en grados : ");
            double d = double.Parse(Console.ReadLine());

            //d en radianes

            double dR = d * (Math.PI / 180);

            double y = w * Math.Cos(dR) - x;


            Console.WriteLine("El valor de y es =  " + y);
            
            
            //video solución https://youtu.be/0yNeT2FA-fw?t=277

        }
    }

}
