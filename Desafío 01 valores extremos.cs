using System;

namespace Desafío_01_valores_extremos
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            int i = 0, mayor = 0, menor = 200; //Variable de intentos, maximos y minimos

            string anciano = "";
            
            string joven = "";

            Console.WriteLine("Ingrese el número de personas con las cuales se hará el promedio");

            int npersonas = int.Parse(Console.ReadLine());
            

            while (i < npersonas)
            {
                Console.WriteLine("Nombre de la persona");

                string nombre = Console.ReadLine();

                Console.WriteLine("Edad de la persona");

                int edad = int.Parse(Console.ReadLine());

                if (edad > mayor)
                {
                    mayor = edad; 
                    anciano = nombre;
                }
                if (edad < menor)
                {
                    menor = edad; 
                    joven = nombre;
                }

                total += edad;

                i++;
            }

            double promedio =Math.Round( total / npersonas);
            Console.WriteLine("El promedio de las edades es  = " + promedio);
            Console.WriteLine("La edad del mayor es = " + mayor);
            Console.WriteLine("El mayor de todos es "+anciano);
            Console.WriteLine("La edad del menor es = " + menor);
            Console.WriteLine("El mayor de todos es " + joven);


            //video solución https://youtu.be/huy8ma7pGGw

        }
    }
}
