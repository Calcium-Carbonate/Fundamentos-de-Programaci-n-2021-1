using System;

namespace Bubblesort_no_yaiba
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = { "Nezuko", "Tanjiro", "Zenitsu", "Inosuke", "Genya", "Kanao", "Tomioka" };
            double[] estatura = { 153, 165, 164.5, 164, 180, 156, 176 };
            double temp = 0;
            string nombreTemp = "";
            for (int i = 0; i < estatura.Length; i++)
            {
                for (int c = 0; c < estatura.Length - 1; c++)
                {
                    if (estatura[c] > estatura[c + 1])
                    {
                        temp = estatura[c + 1];

                        nombreTemp = nombres[c + 1];
                            
                        estatura[c + 1] = estatura[c];
                        nombres[c + 1] = nombres[c];

                        estatura[c] = temp;
                        nombres[c] = nombreTemp;

                    }
                }
            }

            for (int j = 0; j < estatura.Length; j++)
            {
                Console.WriteLine("Estatura número  " + j + " es igual a " + estatura[j]+ " y le pertenece a  " + nombres[j]);
            }
        }

    }
}
  
