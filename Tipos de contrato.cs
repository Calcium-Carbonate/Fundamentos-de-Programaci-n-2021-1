using System;

namespace Tema_ipos_de_contrato
{
    class Program
    {
        static void Main(string[] args)

        {
            while (true)
            {

                Console.WriteLine("Por favor escriba su salario mensual");

                int salario = int.Parse(Console.ReadLine());

                Console.WriteLine("Elija su tipo de contrato");

                Console.WriteLine("1 = dependiente 2 = Independiente ");

                int tcontrato = int.Parse(Console.ReadLine());

                double cotizacion = salario * (0.4);

                //salario MINIMO DEL AÑO PASADO(2020) POR FAVOR
                int smmlv = 877803;



                //2 = independiente

                if (tcontrato == 2)
                {
                    Console.WriteLine("Ingrese el número del 1 al 5 que sea equivalente a su clase del riesgo");

                    int riesgo = int.Parse(Console.ReadLine());

                    //COTIZACIÓN CON VALOR MENOR AL SALARIO MINIMO
                    if (cotizacion <= smmlv)

                    {


                        if (riesgo == 1)
                        {

                            double pension = smmlv * 0.16;

                            double eps = smmlv * 0.125;

                            double arl = smmlv * ((0.522) / 100);

                            double deduccion1 = pension + eps + arl;

                            double salarioreal = salario - deduccion1;

                            Console.WriteLine("Su salario real mensual es " + salarioreal);

                            double salarioanual = 12 * salarioreal;

                            Console.WriteLine("Sus ingresos anuales son " + salarioanual);

                        }

                        if (riesgo == 2)
                        {
                            double pension = smmlv * 0.16;

                            double eps = smmlv * 0.125;

                            double arl = smmlv * ((1.044) / 100);

                            double deduccion1 = pension + eps + arl;

                            double salarioreal = salario - deduccion1;

                            Console.WriteLine("Su salario real mensual es " + salarioreal);

                            double salarioanual = 12 * salarioreal;

                            Console.WriteLine("Sus ingresos anuales son " + salarioanual);

                        }

                        if (riesgo == 3)
                        {

                            double pension = smmlv * 0.16;

                            double eps = smmlv * 0.125;
                           
                            double arl = smmlv * ((2.436) / 100);

                            double deduccion1 = pension + eps + arl;

                            double salarioreal = salario - deduccion1;

                            Console.WriteLine("Su salario real mensual es " + salarioreal);

                            double salarioanual = 12 * salarioreal;

                            Console.WriteLine("Sus ingresos anuales son " + salarioanual);

                        }

                        if (riesgo == 4)
                        {

                            double pension = smmlv * 0.16;

                            double eps = smmlv * 0.125;

                            double arl = cotizacion * ((4.350) / 100);

                            double deduccion1 = pension + eps + arl;

                            double salarioreal = salario - deduccion1;

                            Console.WriteLine("Su salario real mensual es " + salarioreal);

                            double salarioanual = 12 * salarioreal;

                            Console.WriteLine("Sus ingresos anuales son " + salarioanual);

                        }

                        if (riesgo == 5)
                        {

                            double pension = smmlv * 0.16;

                            double eps = smmlv * 0.125;

                            double arl = cotizacion * ((6.960) / 100);

                            double deduccion1 = pension + eps + arl;

                            double salarioreal = salario - deduccion1;

                            Console.WriteLine("Su salario real mensual es " + salarioreal);

                            double salarioanual = 12 * salarioreal;

                            Console.WriteLine("Sus ingresos anuales son " + salarioanual);

                        }


                    }
                    //Cotización mayor al salario MINIMO
                    if (cotizacion > smmlv)
                    {

                        if (riesgo == 1)
                        {
                            double pension = cotizacion * 0.16;

                            double eps = cotizacion * 0.125;

                            double arl = cotizacion * ((0.522) / 100);

                            double deduccion = pension + eps + arl;

                            double salarioreal = salario - deduccion;

                            Console.WriteLine("Su salario real mensual es " + salarioreal);

                            double salarioanual = 12 * salarioreal;

                            Console.WriteLine("Sus ingresos anuales son " + salarioanual);

                        }

                        if (riesgo == 2)
                        {
                            double pension = cotizacion * 0.16;

                            double eps = cotizacion * 0.125;

                            double arl = cotizacion * ((1.044) / 100);

                            double deduccion = pension + eps + arl;

                            double salarioreal = salario - deduccion;

                            Console.WriteLine("Su salario real mensual es " + salarioreal);

                            double salarioanual = 12 * salarioreal;

                            Console.WriteLine("Sus ingresos anuales son " + salarioanual);
                        }

                        if (riesgo == 3)
                        {
                            double pension = cotizacion * 0.16;

                            double eps = cotizacion * 0.125;

                            double arl = cotizacion * ((2.436) / 100);

                            double deduccion = pension + eps + arl;

                            double salarioreal = salario - deduccion;

                            Console.WriteLine("Su salario real mensual es " + salarioreal);

                            double salarioanual = 12 * salarioreal;

                            Console.WriteLine("Sus ingresos anuales son " + salarioanual);
                        }

                        if (riesgo == 4)
                        {
                            double pension = cotizacion * 0.16;

                            double eps = cotizacion * 0.125;

                            double arl = cotizacion * ((4.35) / 100);

                            double deduccion = pension + eps + arl;

                            double salarioreal = salario - deduccion;

                            Console.WriteLine("Su salario real mensual es " + salarioreal);

                            double salarioanual = 12 * salarioreal;

                            Console.WriteLine("Sus ingresos anuales son " + salarioanual);
                        }

                        if (riesgo == 5)
                        {
                            double pension = cotizacion * 0.16;

                            double eps = cotizacion * 0.125;

                            double arl = cotizacion * ((6.96) / 100);

                            double deduccion = pension + eps + arl;

                            double salarioreal = salario - deduccion;

                            Console.WriteLine("Su salario real mensual es " + salarioreal);

                            double salarioanual = 12 * salarioreal;

                            Console.WriteLine("Sus ingresos anuales son " + salarioanual);
                        }

                    }


                }

                //1 dependiente
                else
                {

                    if (cotizacion < smmlv)
                    {
                        double pension = smmlv * 0.04;

                        double eps = smmlv * 0.04;

                        double deduccion1 = pension + eps;

                        double salarioreal = salario - deduccion1;

                        Console.WriteLine("Su salario real mensual es " + salarioreal);

                        double salarioanual = (12 * salarioreal) + salario;

                        Console.WriteLine("Sus ingresos anuales son " + salarioanual);
                    }

                    if (cotizacion >= smmlv)
                    {
                        double pension = cotizacion * 0.04;

                        double eps = cotizacion * 0.04;

                        double deduccion1 = pension + eps;

                        double salarioreal = salario - deduccion1;

                        Console.WriteLine("Su salario real mensual es " + salarioreal);

                        double salarioanual = (12 * salarioreal) + salario;

                        Console.WriteLine("Sus ingresos anuales son " + salarioanual);

                    }

                }
            }
        }

    }
}
