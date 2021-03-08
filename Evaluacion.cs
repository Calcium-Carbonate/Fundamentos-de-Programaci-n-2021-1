using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

class Evaluacion {

    public Evaluacion(string[] names, string[] ids, int[] ages, double[] gpas) {
        this.names = names;
        this.ids = ids;
        this.ages = ages;
        this.gpas = gpas;
    }

    // ----- PARCIAL -----

    // Espacio para declaración de variables
    string[] names;
    string[] ids;
    int[] ages;
    double[] gpas;

    double mediana =0, promedioGpa=0,sumaGpa=0;
    int contadorEst = 0;
    public int PrimerPunto() {
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        string[] nombres = names;
        int[] edades = ages;
        double[] notas = gpas;
        int salida = 0;
        for (int i = 0; i < edades.Length; i++)
        {

          for(int c = 0; c < edades.Length - 1; c++)
            {
                if (edades[c] > edades[c + 1])
                {
                    int edadtemp =edades[c+1];
                    string nombreTemp = nombres[c + 1];
                    double notaTemp = notas[c + 1];

                    edades[c + 1] = edades[c];
                    nombres[c + 1] = nombres[c];
                    notas[c + 1] = notas[c];

                    edades[c] = edadtemp;
                    nombres[c] = nombreTemp;
                    notas[c] = notaTemp;
                }
            }
        }

        if (edades.Length % 2 == 0)//cantidad de datos par
        {
            mediana = ((edades[(edades.Length/2)-1])+(edades[(edades.Length / 2)]))/2.0 ;        
        }

        else
        {
            mediana = edades[(edades.Length) / 2];
        }

        for (int i = 0; i < notas.Length; i++)
        {

            sumaGpa += notas[i];
            
        }

        promedioGpa = sumaGpa / notas.Length;

        for (int i = 0; i < notas.Length; i++)
        {

            if (edades[i] <=mediana && notas[i]>=promedioGpa)
            {
                contadorEst++;
            }

        }
        Console.WriteLine("mediana " + mediana);
        Console.WriteLine("promedio " + promedioGpa);
        Console.WriteLine("Salidad es igual a  " + contadorEst);

        salida = contadorEst;

        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] SegundoPunto() {
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
 // Puede cambiarse por una lista si se considera pertinente
 
        string[] salida = new string[contadorEst];
        int contador1 = 0;

        while(contador1 < salida.Length)
        {
            for (int i = 0; i < gpas.Length; i++)
            {

                if (ages[i] <= mediana && gpas[i] >= promedioGpa)
                {

                    salida[contador1] = names[i];
                    contador1++;
                }

                if (contador1 == salida.Length) break;
            }
        }

        //- Arriba de esta línea va su código --------
        return Extras.To(salida);
    }

    public string[] TercerPunto() {
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        string[] salida = new string[3]; // Puede cambiarse por una lista si se considera pertinente

        string[] nombres = names;
        int[] edades = ages;
        double[] notas = gpas;
        double promedioEdad = 0, sumaEdad=0;
        int contador2 = 0;
        for (int i = 0; i < notas.Length; i++)
        {

            for (int c = 0; c < notas.Length - 1; c++)
            {
                if (notas[c] > notas[c + 1])
                {
                    int edadtemp = edades[c + 1];
                    string nombreTemp = nombres[c + 1];
                    double notaTemp = notas[c + 1];

                    edades[c + 1] = edades[c];
                    nombres[c + 1] = nombres[c];
                    notas[c + 1] = notas[c];

                    edades[c] = edadtemp;
                    nombres[c] = nombreTemp;
                    notas[c] = notaTemp;
                }
            }
        }
        for (int i = 0; i < notas.Length; i++)
        {

            sumaEdad += edades[i];

        }

        promedioEdad = sumaEdad / edades.Length;

        while (contador2 != 3)
        {
            for (int i = 0; i < gpas.Length; i++)
            {

                if (ages[i] <= promedioEdad)
                {

                    salida[contador2] = names[i];
                    contador2++;
                }

                if (contador2 == 3) break; ;
            }
        }

        //- Arriba de esta línea va su código --------
        return Extras.To(salida);
    }

    public string[] CuartoPunto() {
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        List<string> salida = new List<string>(); // Puede cambiarse por una lista si se considera pertinente
        int contadorV = 0;
        for (int i = 0; i < names.Length; i++)
        {

            for (int c = 0; c < names[i].Length; c++)
            {

                char letra = names[i][c];
                if (letra == 'a' || letra == 'A') contadorV++;
                else if (letra == 'e' || letra == 'E') contadorV++;
                else if (letra == 'i' || letra == 'I') contadorV++;
                else if (letra == 'o' || letra == 'O') contadorV++;
                else if (letra == 'u' || letra == 'U') contadorV++;
            }

            if (contadorV >= 2)
            {
                salida.Add(names[i]);
                contadorV = 0;
            }

            else { contadorV = 0; }
        }


        //- Arriba de esta línea va su código --------
        return Extras.To(salida);
    }
}
