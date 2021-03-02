using System;

namespace Ciclos__simulacro_p2_T1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al jueguito de dados");

            Random azar = new Random();
            int dado1 = 0, dadoEsp = 0, contadorEps = 2, contadorU = 0, contadorS = 0, total = 0, vidas = 3, turnos = 0;

            string especial = "";

            Console.WriteLine("Desea empezar(S/N)");

            string continuar = Console.ReadLine();

            while (continuar != "S" && continuar != "N") //validar
            {
                Console.WriteLine("Por favor ingrese una respuesta Si(S) o No(N)");

                continuar = Console.ReadLine();
            }

            while (continuar == "S")
            {
                turnos++;

                Console.WriteLine("Su puntaje va en " + total);

                Console.WriteLine("Usted tiene " + vidas + " vidas");

                Console.WriteLine("Estos son sus dados especiales " + contadorEps);

                dadoEsp = 0;

                if (contadorEps > 0) //Si el contador de dados especiales es mayor a 0 se le pregunta al usuario si quiere utilizar uno
                {
                    Console.WriteLine("Desea utilizar sus dados especiales (S/N)");

                    especial = Console.ReadLine();
                    while (especial != "S" && especial != "N") //Validar
                    {
                        Console.WriteLine("Por favor ingrese una respuesta Si(S) o No(N)");

                        especial = Console.ReadLine();  
                    }
                }

                if (especial == "S")
                {
                    dadoEsp = azar.Next(1, 13);
                    contadorEps--;
                    dado1 = dadoEsp;
                    especial = "";
                }
 
                else { dado1 = azar.Next(1, 7); }

                //trampita sensual
                //dado1 = int.Parse(Console.ReadLine());

                total += dado1;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Este fue su dado este turno " + dado1);
                Console.ForegroundColor = ConsoleColor.White;

                if (total >= 100)
                {
                    Console.WriteLine("Felicidades usted obtuvo un total de  " + total + " y alcanzó la victoria");
                    break;
                }

                if (dado1 == 1)
                {
                    contadorU++;
                    if (contadorU == 1) { Console.WriteLine("Si sacas otro 1 perderás una vida"); }


                    if (contadorU == 2)
                    {
                        Console.WriteLine("Sacaste dos veces 1, se te restará una vida");
                        vidas--;
                        total -= 10;
                        contadorU = 0;
                        Console.WriteLine("VIDAS  " + vidas);
                        Console.WriteLine("Su total este turno  " + total);
                    }
                }

                if (vidas == 0)
                {
                    Console.WriteLine("Te quedaste sin vidas, has pedido");
                    break;
                }

                if (dado1 == 6)
                {
                    contadorS++;

                    if (contadorS == 1) { Console.WriteLine("Si sacas otro seis sumaras otra vida "); }


                    if (contadorS == 2 && vidas < 3)
                    {
                        vidas++;
                        Console.WriteLine("Obtuviste una vida al sacar 6 dos veces seguidas");
                        Console.WriteLine("VIDAS  " + vidas);
                    }
                }
                else
                {
                    contadorS = 0;
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
            Console.WriteLine("Sus vidas   " + vidas);
            Console.WriteLine("Número de turnos " + turnos);
            Console.WriteLine("Fin del juego");
        }
    }

    //VIDEO SOLUCIÓN https://youtu.be/7ghgf180OzY
}

