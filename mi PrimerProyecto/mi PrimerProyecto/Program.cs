using System;
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

            Console.WriteLine(" La media aritmetica es: {0}, y la desviación típica es: {1}, la media armonica es: {2} ",
                media (numeros), tipica(numeros), armonica(numeros));
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

            static double armonica (string[ ] serie) { 
                double armónica = 0;
                foreach (string num in serie )  {
                    armónica += (1.0 / double.Parse(num));
                }
                armónica = serie.Length / armónica;
                return Math . Round(armónica, 2);
            }
        }
    }
}
    
