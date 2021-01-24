using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada de variables en la consola
            Console.Write("Inserte el valor de Z : " );

            double z = double.Parse(Console.ReadLine());

            Console.Write("Inserte el valor de Y : " );

            double y = double.Parse(Console.ReadLine());

            //Hipotenusa

            double t = Math.Sqrt((z * z) + (y * y));

            //Valor del angulo c, recordar que nos lo dará en radianes

            double c = Math.Atan(z / y);

            double cg = c * (180 / Math.PI);

            //valor del angulo a

            double a = 180 - (90 + cg);

           
            Console.WriteLine("El valor de la hipotenusa es = " + t);

            Console.WriteLine("El valor del ángulo c es = " + cg +" grados");

            Console.WriteLine("El valor del ángulo a es = " + a + " grados");
        

            //Video solución https://youtu.be/Kcdbt3Mj3RM

        }
    }
}
