using System;

namespace Desafio_01___4_d
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                Console.Write("Ingrese w: ");
                double w = double.Parse(Console.ReadLine());


                Console.Write("Ingrese t: ");
                double t = double.Parse(Console.ReadLine());

                Console.Write("Ingrese c en grados: ");
                double c = double.Parse(Console.ReadLine());



                // c en radianes

                double cR = c * (Math.PI / 180);

                double z = t * Math.Sin(cR);

                double y = t * Math.Cos(cR);

                double d = Math.Asin(z / w);


                double x = w * Math.Cos(d) - y;


                //Salida X
                Console.WriteLine("El valor de x es = " + x);


            }
        }
    }
}
