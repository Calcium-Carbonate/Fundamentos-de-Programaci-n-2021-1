using System;

namespace Matrices_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string[] valores = { "-", "-", "O", "X" };
            int n = 10;
            int m = 15;

            int contador = 0;

            double contadorX = 0,contadorO = 0, contadorG = 0, porcentajeX = 0, porcentajeO = 0, porcentajeG = 0; ;

            string[,] tablero = new string[n, m];
            string[,] salida = new string[n, m];
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    int indice = random.Next(0, valores.Length);
                    tablero[i, j] = valores[indice];
                    salida[i, j] = "-";

                    if (tablero[i, j] == "X") contadorX++;
                    if (tablero[i, j] == "O") contadorO++;
                    if (tablero[i, j] == "-") contadorG++;

                }
            }

            Console.WriteLine("ENTRADA: ");
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    Console.Write("|" + tablero[i, j]);
                }
                Console.Write("|\n");
            }

            porcentajeX = (contadorX / (n * m))*100;
            porcentajeO = (contadorO / (n * m))*100;
            porcentajeG = (contadorG / (n * m))*100;

            Console.WriteLine("El porcentaje de X es " + porcentajeX + "%");

            Console.WriteLine("El porcentaje de O es " + porcentajeO + "%");

            Console.WriteLine("El porcentaje de - es " + porcentajeG + "%");



            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                   //FULAS
                    for(int k=j; k>=0; k--)//Revisar hacia la izquierda con el limite en la columna 0
                    {
                        if (k == j) continue;
                        if(tablero[i,k]==tablero[i,j]) contador++;
                        else break;
                    }

                    for (int k = j; k <tablero.GetLength(1); k++)//Revisar hacia la derecha con el limite en tamaño de la fila
                    {
                        if (k == j) continue;
                        if (tablero[i, k] == tablero[i, j]) contador++;
                        else break;
                    }

                    if(contador>=2 && tablero[i, j] == "X")
                    {
                        salida[i, j] = "1";
                    }

                    if (contador >= 2 && tablero[i, j] == "O")
                    {
                        salida[i, j] = "2";
                    }

                    contador = 0;
                    //Columnas

                    for (int k = i; k >= 0; k--)//Revisar hacia la izquierda con el limite en la columna 0
                    {
                        if (k == i) continue;
                        if (tablero[k, j] == tablero[i, j]) contador++;
                        else break;
                    }

                    for (int k = i; k < tablero.GetLength(0); k++)//Revisar hacia la derecha con el limite en tamaño de la columnas
                    {
                        if (k == i) continue;
                        if (tablero[k, j] == tablero[i, j]) contador++;
                        else break;
                    }

                    if (contador >= 2 && tablero[i, j] == "X")
                    {
                        salida[i, j] = "1";
                    }

                    if (contador >= 2 && tablero[i, j] == "O")
                    {
                        salida[i, j] = "2";

                    }

                    contador = 0;
                }
            }




            Console.WriteLine("\nSALIDA: ");
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    Console.Write("|" + salida[i, j]);
                }
                Console.Write("|\n");
            }
            Console.WriteLine("\n");
        }
    }

}
