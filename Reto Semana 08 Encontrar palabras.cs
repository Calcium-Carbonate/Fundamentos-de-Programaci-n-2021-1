using System;

namespace Reto_Semana_08_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una frase");
            string frase =Console.ReadLine().ToUpper();

            Console.WriteLine("Ingrese la palabra que quiera contar");
            string palabra = Console.ReadLine().ToUpper();

            string[] fraseS = frase.Split(" ");
            
            int contadorPalabras = 0;


            for (int i = 0; i < fraseS.Length; i++)
            {
                if(fraseS[i] == palabra)
                {
                    contadorPalabras++;

                    Console.WriteLine("Palabra encontrada en la posición "+(i + 1));
                }
            }

            Console.WriteLine("La palabra se repitió un total de " + contadorPalabras + " veces");

        //https://www.youtube.com/watch?v=7B4LqRgpiDU
        }
    }
}
