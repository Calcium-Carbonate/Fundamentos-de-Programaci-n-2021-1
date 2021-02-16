using System;

namespace _08_Ciclos__simulacro_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al jueguito de dados");

            Random azar = new Random();
            int dado1 = 0, dado2 = 0, total = 0, contadorPar=0;

            double porcentajeseis = 0, contador = 0, contadorSeis = 0; //Utilizar db para el % 

            string continuar = "S";

            Console.WriteLine("Consecutivo opcional:Si usted obtiene 3 dobles consecutivos automaticamente ganará");
            Console.WriteLine("Desea jugar con está regla(S / N)");

            string consecutivoOP = Console.ReadLine();


            while (continuar == "S")
            {
               // dado1 = azar.Next(1, 7);

               // dado2 = azar.Next(1, 7);


                //TrampitaSensual

                dado1 = int.Parse(Console.ReadLine());

                dado2 = int.Parse(Console.ReadLine());


                total += dado1;
                total += dado2;
                contador++;
                Console.WriteLine("Su total es de " + total);
                Console.WriteLine("El dado 1 tiene un valor de " + dado1);
                Console.WriteLine("El dado 2 tiene un valor de " + dado2);

                if (consecutivoOP == "S") //Si aceptamos el consecutivoOP
                { 
                if (dado1 == dado2)//sacamos doble
                {
                    contadorPar++;//me cuenta +1 cada vez que sea doble
                    Console.WriteLine("contador par " + contadorPar);
                    if (contadorPar == 3)//si el contador de dobles es 3, significa que sacamos 3 seguidos, victoria
                    {
                        Console.WriteLine("GANASTE! Sacaste 3 dobles consecutivos");
                        continuar = "N";
                    }
                }
                else
                {
                    contadorPar = 0; //si no sacamos otro doble se reinicia el contador
                }
                }


                if (dado1 + dado2 > 6)//contador para cada vez que saquemos mas de seis
                { 
                    contadorSeis++;
                }

              
                if(dado1 ==1 && dado2 == 1)//Si ambos dados dan 1 perdemos
                {
                    Console.WriteLine("Eliminado");
                    continuar = "N";
                }

                if (total >= 100)//ganamos si sacamos 100 o más puntos
                {
                    Console.WriteLine("GANASTE!");
                    continuar = "N";
                }
               
               

                if (continuar == "S")//Preguntamos si queremos seguir
                {
                    Console.WriteLine("Desea lanzar otra vez?(S/N)");

                    continuar = Console.ReadLine();


                }

            }
            //Salida, mostrar total, porcentaje de veces que sacamos más de 6 y mensaje de despedida
            porcentajeseis = (contadorSeis / contador) * 100; 

                Console.WriteLine("Su total es de " + total);

                Console.WriteLine("Número de turnos " + contador);

                Console.WriteLine("El porcentaje de veces que la suma de los dados fue mayor a seis es " + porcentajeseis + "%");

                Console.WriteLine("Gracias por jugar");


   

        }
    }
}
