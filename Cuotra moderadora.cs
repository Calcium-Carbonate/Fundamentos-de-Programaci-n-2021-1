using System;

namespace Desafio_02_Calculo_Cuota_Moderadora
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

            int tarifaB = smmvl * 5;

            if (salario < tarifaA)
            {

                Console.WriteLine("Usted debe pagar la tarifa A");

                Console.WriteLine("El valor de la cuota moderadora es de $ 3.500 ");



            }

            if (tarifaA <= salario && salario < tarifaB)
            {

                Console.WriteLine("Usted debe pagar la tarifa B");
                  
                Console.WriteLine("El valor de la cuota moderadora es de $ 14.500 ");
            }


            if (salario >= tarifaB)
            {

                Console.WriteLine("Usted debe pagar la tarifa C");

                Console.WriteLine("El valor de la cuota moderadora es de $ 36.800 ");
            }


        }
    }
    }

