using System;

namespace Black_Jack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al Blackjack");

            Random azar = new Random();

            Console.WriteLine("Por favor ingrese el número de jugadores (Máx 5 Min 2)"); 

            int n = int.Parse(Console.ReadLine()); //se ingresa el número de jugadores máximo

            
            while( 5 < n || n==1) //validación
            {
                Console.WriteLine("Error.Ingrese por favor un número adecuado de jugadores");
                n = int.Parse(Console.ReadLine());
            }

            string[] nombresJ = new string[n]; //arreglo para los nombres de los jugadores
            int[] puntajes = new int[n]; //arreglo para los puntajes de los jugadores

            for(int c=0; c<n; c++) //introducir los nombres de los jugadores(n) en el arreglo nombresJ
            {
                Console.WriteLine("Escriba el nombre del jugador " + (c+1));
                nombresJ[c] = Console.ReadLine();
            }    


           for(int jugador=0;jugador<n; jugador++) //Se va a repetir según el número de jugadores que estén en la partida
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Bienvenido jugador " +(nombresJ[jugador])); //Saludo al jugardor de turno 
                Console.ForegroundColor = ConsoleColor.White;

                int primeracarta = azar.Next(1, 11);
                int segundacarta = azar.Next(1, 11);
                string Respuesta = "";

                int total = primeracarta + segundacarta;

                Console.WriteLine("Su primera carta es  " + primeracarta);

                Console.WriteLine("Su segunda carta es  " + segundacarta);

                Console.WriteLine("Su puntaje ES  " + total);

                Console.WriteLine("Desea seguir? (S/N)");

                Respuesta = Console.ReadLine();

                while (Respuesta != "S" && Respuesta != "N")
                {
                    Console.WriteLine("Por favor escriba Sí(S) o No(N)");
                    Respuesta = Console.ReadLine();
                }

                int nuevacarta = 0;

                if(Respuesta == "N") //se retira
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Su puntaje fue  " + total);
                    Console.ForegroundColor = ConsoleColor.White;
                    puntajes[jugador] = total; //Se pone el total en el arreglo puntajes en la posición jugador
                    
                }

                while (Respuesta == "S" && total < 21)//mientra su total sea menor a 21 y quiera seguir jugando procede a crear nuevas cartas
                {


                    nuevacarta = azar.Next(1, 11);
                    total += nuevacarta;
                    puntajes[jugador] = total; //Reemplazar el valor del arreglo cada que el jugador acepte seguir jugando

                    if (total < 21)//continuar mientras total sea menor a 21
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

                    if (total == 21)//victoria estandar
                    {
                        Console.WriteLine("Su carta fue  " + nuevacarta);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Felicidades has obtenido una puntuación de 21");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    if (total > 21)//total por encima de 21=derrota
                    {
                        Console.WriteLine("Su carta fue " + nuevacarta);
                        Console.WriteLine("Mala esa, crack");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Su puntaje fue  " + total);
                        Console.ForegroundColor = ConsoleColor.White;
                        puntajes[jugador] = 0; //Se pone el total en el arreglo en 0 porque se entiende que el puntaje del jugador no cuenta 
                    }

                }

                Console.WriteLine("Gracias por jugar");

            }

            for(int l=0;l<n; l++) //Bubblesort para organizar los nombres y puntajes de mayor a menor
            {
                for(int o = 0; o < puntajes.Length - 1; o++) //organizar de mayor a menor
                {
                    if (puntajes[o + 1] > puntajes[o])
                    {
                        int puntajeTemp =puntajes[o]; //variable temporal de puntaje
                        string nombreTempo = nombresJ[o];//variable temporal de nombre

                        puntajes[o] = puntajes[o + 1];
                        nombresJ[o] = nombresJ[o+1];

                        puntajes[o + 1] = puntajeTemp;
                        nombresJ[o + 1] = nombreTempo;

                    }
                }
            }

            Console.WriteLine("El juego ha terminado");
            Console.ForegroundColor = ConsoleColor.Yellow;
            for(int f=0; f<2;f++)//Escribir el primer y segundo puesto
            { 
            Console.WriteLine((f + 1) + " Puesto " +  "es de "+ nombresJ[f] +" con un Puntaje molón de  " + puntajes[f]);
            }
            Console.ForegroundColor = ConsoleColor.White;

        }
            //video solución https://youtu.be/c_QBBzAe-HM
    }
 }

