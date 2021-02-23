using System;

namespace Black_Jack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al Blacjack");

            Random azar = new Random();

            Console.WriteLine("Por favor ingrese el número de jugadores (Máx 5 Min 2)");

            int n = int.Parse(Console.ReadLine());

            int jugador = 0;

            int puntajeGanador = 0;

            int jugadorGanador = 0;
            
            while( 5 < n || n==1)
            {
                Console.WriteLine("Error.Ingrese por favor un número adecuado de jugadores");
                n = int.Parse(Console.ReadLine());
            }

            while(jugador < n)
            {
                jugador++;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Bienvenido jugador " +(jugador));
                Console.ForegroundColor = ConsoleColor.White;


                int primeracarta = azar.Next(1, 11);
                int segundacarta = azar.Next(1, 11);
                string Respuesta = "";

                int total = primeracarta + segundacarta;

                Console.WriteLine("Su primera carta es  " + primeracarta);

                Console.WriteLine("Su sengunda carta es  " + segundacarta);

                Console.WriteLine("Desea seguir? (S/N)");

                Respuesta = Console.ReadLine();

                while (Respuesta != "S" && Respuesta != "N")
                {
                    Console.WriteLine("Por favor escriba Sí(S) o No(N)");
                    Respuesta = Console.ReadLine();
                }

                int nuevacarta = 0;

                if(Respuesta == "N") {
                    if (puntajeGanador < total && total <= 21)
                    {
                        puntajeGanador = total;
                        jugadorGanador = jugador;
                    }
                }

                while (Respuesta == "S" && total < 21)
                {


                    nuevacarta = azar.Next(1, 11);
                    total += nuevacarta;



                    if (total < 21)
                    {

                        Console.WriteLine("Su carta fue  " + nuevacarta);

                        Console.WriteLine("Este es su puntaje ahora  " + total);

                        Console.WriteLine("Desea seguir? (S/N)");


                        Respuesta = Console.ReadLine();
                        while (Respuesta != "S" && Respuesta != "N")
                        {
                            Console.WriteLine("Por favor escriba Sí(S) o No(N)");
                            Respuesta = Console.ReadLine();
                        }
                    }

                    if (total == 21)
                    {
                        Console.WriteLine("Su carta fue  " + nuevacarta);
                        Console.WriteLine("Felicidades has obtenido una puntuación de 21");
                    }

                    if (total > 21)
                    {

                        Console.WriteLine("Mala esa, crack");
                        Console.WriteLine("Su puntaje fue  " + total);
                    }

                    if (puntajeGanador < total && total <= 21)
                    {
                        puntajeGanador = total;
                        jugadorGanador = jugador;
                    }

                }

                Console.WriteLine("Gracias por jugar");

             

            }

            Console.WriteLine("El juego ha terminado");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("El ganador es  " + jugadorGanador + "  Con un total de  " + puntajeGanador);
            Console.ForegroundColor = ConsoleColor.White;


        }
            //video solución https://youtu.be/c_QBBzAe-HM
    }
 }

