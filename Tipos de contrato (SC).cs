using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        
        {
            Console.WriteLine("Por favor escriba su salario mensual");

            int salario = int.Parse(Console.ReadLine());

            Console.WriteLine("Elija su tipo de contrato");

            Console.WriteLine("1 = dependiente 2 = Independiente ");

            byte tcontrato = byte.Parse(Console.ReadLine()); //byte porque no necesitamos numeros negativos

            double cotizacion = salario * (0.4);

            double pension, eps, arl = 0; //establecer variables desde 0, luego se les cambia el valor y no hay que definirlas más

            //salario MINIMO DEL AÑO PASADO(2020) POR FAVOR
            int smmlv = 877803;

            if (cotizacion < smmlv) { cotizacion = smmlv; }

            switch (tcontrato)
            {

                case 1://Dependiente

                    pension = cotizacion * 0.04;

                    eps = cotizacion * 0.04;

                    double salarioreal = salario - (pension + eps + arl);

                    Console.WriteLine("Su salario real es " + salarioreal);

                    double salarioanual = salarioreal*12 + salario;

                    Console.WriteLine("Su salario anual es " + salarioanual);

                    ; break;

                case 2: //Independiente 

                    Console.WriteLine("Escriba el número de 1 al 5 que corresponda con su clase de riesgo");
                    byte criesgo = byte.Parse(Console.ReadLine());

                    switch (criesgo)//Nivel de riesgo
                    {
                        case 1: arl = cotizacion * (0.522 / 100); break;
                        case 2: arl = cotizacion * (1.044 / 100); break;
                        case 3: arl = cotizacion * (2.436 / 100); break;
                        case 4: arl = cotizacion * (4.350 / 100); break;
                        case 5: arl = cotizacion * (6.960 / 100); break;
                    }

                    pension = cotizacion * 0.16;

                    eps = cotizacion * 0.125;

                    double realsalario = salario - (pension + eps + arl);

                    Console.WriteLine("Su salario real es " + realsalario);

                    double anualsalario = realsalario * 12 ;

                    Console.WriteLine("Su salario anual es " + anualsalario);
                    ; break;
            }

        //VIDEO SOLUCIÓN https://youtu.be/PDE6i7zc55I

        }      
    }
 }


