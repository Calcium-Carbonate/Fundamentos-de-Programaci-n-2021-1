using System;

namespace Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba el valor de x");
            double x = double.Parse(Console.ReadLine());
            
            double e = 0;
            
          for (int i = 0; i < 100; i++)
            {
                e += ((Math.Pow(x,i)) / Factorial(i));


            }
            
            Console.WriteLine("El valor de e^x es   " + e);
        }

        static double Factorial(double valor)
        {
            double total = 1;
            for(int i = 1; i<=valor; i++)
            {
                total *= i;
            }

            return total;
        }
    }

    //video solución https://youtu.be/c_QBBzAe-HM?t=422
}
