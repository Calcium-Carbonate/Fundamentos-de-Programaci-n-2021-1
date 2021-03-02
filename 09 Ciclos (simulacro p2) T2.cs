using System;

namespace _09_Ciclos__simulacro_p2__T2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bienvenido al otro jueguito de dados");

            Random azar = new Random();
            int dado1 = 0,dado2=0, turnos = 0, turnoVisual=0, total = 0, vidas = 3;
            Console.WriteLine("Desea empezar(S/N)");

            string continuar = Console.ReadLine();
            while (continuar != "S" && continuar != "N")
            {
                Console.WriteLine("Por favor ingrese una respuesta Si(S) o No(N)");

                continuar = Console.ReadLine();
            }


            while (continuar == "S")
            {
                turnos++; //turnos para el contador para usar los dos dados
                turnoVisual++; //turnos totales para usar el modulo
                if (turnoVisual % 2 == 0)//restar vidas los turnos pares
                {
                    vidas--;
                }

                dado1 = azar.Next(1, 7);
                
                dado2 = 0;
                
                total += dado1;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Este fue su dado este turno " + dado1);
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Su puntaje va en " + total);
                Console.WriteLine("Usted tiene " + vidas + " vidas");
                Console.WriteLine("Número de turnos hasta ahora " + turnoVisual);


               
                if (turnos ==3)//Cada 3 turnos 
                {
                    turnos = 0;
                    //Trampita sensual
                    //dado2=int.Parse(Console.ReadLine());
                    dado2 = azar.Next(1, 7);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Este fue su segundo dado este turno " + dado2);
                    Console.ForegroundColor = ConsoleColor.White;
                    total += dado2;
                    Console.WriteLine("Su puntaje va en " + total);
                }
                if (dado1 == dado2)
                {
                    vidas++;
                    Console.WriteLine("Has obtenido una vida!");
                    Console.WriteLine("Vidas " + vidas);

                }
                if (vidas == 0)//Se acaban las vidas
                {
                    Console.WriteLine("Te quedaste sin vidas, has pedido");
                    break;
                }

                if (total >= 100)//victoria
                {
                    Console.WriteLine("Felicidades usted obtuvo un total de  " + total + " y alcanzó la victoria");
                    break;
                }

                Console.WriteLine("Desea continuar? (S/N)");
                continuar = Console.ReadLine();
                while (continuar != "S" && continuar != "N")
                {
                    Console.WriteLine("Por favor ingrese una respuesta Si(S) o No(N)");

                    continuar = Console.ReadLine();
                }
            }

            Console.WriteLine("Su total fue de  " + total);
            Console.WriteLine("Fin del juego");

        }
    }
    //video solución https://youtu.be/7ghgf180OzY
}

