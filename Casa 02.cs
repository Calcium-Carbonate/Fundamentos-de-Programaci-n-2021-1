using System;

namespace Casa_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al jueguito de dados");

            Random azar = new Random();
            int dado1 = 0,dadoActual=0,dadoAnterior=0,  total = 0;

            double contador = 0; 

            string continuar = "S";

            while (continuar == "S")
            {
                //dado1 = azar.Next(1, 13);
                //Trampita sensual
                dado1 = int.Parse(Console.ReadLine());



                total += dado1;

                dadoActual = dado1;


                contador++;
                Console.WriteLine("Su total es de " + total);
                Console.WriteLine("El dado 1 tiene un valor de " + dado1);

                if (dadoActual == 10 && dadoAnterior == 12)
                {
                    Console.WriteLine("Tienes mucha suerte GANASTE");
                   
                    Console.WriteLine("DadoAnterior " + dadoAnterior);
                    Console.WriteLine("DadoActual " + dadoActual);
                    

                    continuar = "N";
                }
    
                if (total >= 100)
                {
                    Console.WriteLine("GANASTE!");
                    continuar = "N";
                }
               
                if (dado1 % 2 != 0 && contador>3) //Modulo diferente de 0
                {
                    Console.WriteLine("PERDISTE! Sacaste un número impar");
                    continuar = "N";
                }
             
                if(continuar=="S")
                {
                    Console.WriteLine("Desea lanzar otra vez?(S/N)");

                    continuar = Console.ReadLine();
                    dadoAnterior = dadoActual;//Se actualiza cada repetición
                }



            }

            Console.WriteLine("Su total es de " + total);

            Console.WriteLine("Número de turnos " + contador);

            Console.WriteLine("Gracias por jugar");




        }
    }
    }

