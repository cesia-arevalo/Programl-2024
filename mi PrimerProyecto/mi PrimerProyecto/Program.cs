using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mi_PrimerProyecto
{
    class Program
    {
        static void Main(string[] args{


            Console .WriteLine ( " lab1 :" ) ;
            double lab1 = double . Parse ( Console . ReadLine ( ) ) ;

            Console .WriteLine ( " lab2 : " ) ;
            double lab2 = double . Parse ( Console . ReadLine ( ) ) ;

            //ejercicio obtener el promedio de una serie de numeros 
            Console .WriteLine ( " parcial1 " ) ;
            double parcial1 = double . Parse ( Console . ReadLine ( ) ) ;

            int[] serie = new int [ ] { 5 , 4 , 6 , 8 , 9 } ; //32
            int suma = 0 ;
            foreach ( int num in serie ) { suma += num ; }
            double c1 = lab1 * 30 / 100 + lab2 * 30 / 100 + parcial1 * 40 / 100 ;

            Console . WriteLine ( " La nota de c1 es {0} " , c1 ) ;

             decimal prom = suma / serie . Length ;
            Console . WriteLine ( " La suma es: {0}, el promedio {1} " , suma, prom ) ;

            Console .WriteLine ( " lab1 : " ) ;
            double Lab1 = double . Parse ( Console . ReadLine ( ) ) ;

            //pausa.
            Console .ReadLine ( ) ;
            Console .WriteLine ( " lab2 : " ) ;
            double Lab2 = double . Parse ( Console . ReadLine ( ) ) ;

            Console . WriteLine ( " parcial1 " ) ;
            double parcial2 = double . Parse ( Console . ReadLine ( ) ) ;

            double c2 = lab1 * 30 / 100 + lab2 * 30 / 100 + parcial1 * 40 / 100 ;
            Console . WriteLine ( " La nota de c2 es {0} " , c2 ) ;

            Console .WriteLine ( " lab1 : " ) ;
            double labo1 = double . Parse ( Console . ReadLine ( ) ) ;

            Console .WriteLine ( " lab2 : " ) ;
            double labo2 = double . Parse ( Console . ReadLine ( ) ) ;

            Console .WriteLine ( " parcial1 " ) ;
            double parcial3 = double . Parse ( Console . ReadLine ( ) ) ;

            double c3 = lab1 * 30 / 100 + lab2 * 30 / 100 + parcial1 * 40 / 100 ;
            Console .WriteLine ( " La nota de c3 es: {0} " , c3 ) ;

            //calcular la nota final
            double notafinal = ( c1 + c2 + c3 ) / 3;
            Console . WriteLine ( " La nota final es: {0} " , notafinal ) ;


            //Pausa.
            Console .ReadLine ( ) ;
        }
    }
}
