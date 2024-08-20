﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mi_PrimerProyecto
{
    class Program
    {
        static void Main(string[] args) {
            //Uso de funciones...
            //ejercicio encontrar la media aritmetica y la desviación típica de una serie de números.

            Console.Write(" Ingrese la serie de números separados por comas: ");
            string serie = Console.ReadLine();​​
            string[] numeros = serie.Split(',');

            Console.WriteLine(" La media aritmetica es: {0}, y la desviacion tipica es: {1} ", media(numeros), tipica(numeros));

            Console.ReadLine();

        }
        static double media(int[] serie) {
            double media = 0;
            foreach (int num in serie) {
                media += num;
            }
            return media / serie.Length;
        }
        static double tipica(int[] serie) {
            double tipica = 0,
                m = media(serie);
            foreach (int num in serie) { 
                tipica += Math.Pow(num - m, 2);
            }
            tipica = Math.Sqrt(tipica / serie.Length);
            return Math.Round(tipica, 2);
        }
    }
}