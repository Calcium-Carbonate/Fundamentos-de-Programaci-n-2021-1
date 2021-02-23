using System;

namespace Seno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Encontrar el Seno de x");
            Console.WriteLine("Escriba el valor de x");
            
            double x = double.Parse(Console.ReadLine());
            
            double sin = 0;



            for (int i = 0; i < 100; i++)
            {
                sin += ((Math.Pow(-1, i)) / (Factorial((2 * i) + 1)))* (Math.Pow(x,((2*i)+1))) ;

            }

            Console.WriteLine("El valor del seno es  " + sin);

        }

        static double Factorial(double valor)
        {
            double total = 1;
            for(int i = 1; i <=valor; i++)
            {
                total *= i;
            }

            return total;
        }
    }

    //video solución https://youtu.be/c_QBBzAe-HM?t=559
}
