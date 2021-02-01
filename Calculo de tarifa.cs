using System;

namespace Desafio_01_calculo_de_tarifa
{
    class Program
    {
        static void Main(string[] args)
        {
            int smmvl = 908526;

            Console.WriteLine("El smmlv en este momento tiene un valor de " + smmvl);
           
            Console.WriteLine("Por favor, ingrese el monto de su salario");
            
            int salario = int.Parse(Console.ReadLine());

            int tarifaA = smmvl * 2;

            int tarifaB = smmvl * 4;

            if (salario < tarifaA)
            {

                Console.WriteLine("Usted debe pagar la tarifa A");

            }

            if(tarifaA <= salario && salario < tarifaB)
            {

                Console.WriteLine("Usted debe pagar la tarifa B");

            }


            if (salario >= tarifaB)
            {

                Console.WriteLine("Usted debe pagar la tarifa C");

            }

    // https://youtu.be/YrY3qt-Dsmo?t=1 video solución
            
        }
    }
}
