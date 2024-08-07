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


            double c1 = lab1 * 30 / 100 + lab2 * 30 / 100 + parcial1 * 40 / 100;
            Console . WriteLine(" La nota de C1 es: {0} ", c1);

            Console.WriteLine ( " Lab1 : " ) ;​
            lab1 = double . Parse ( Console . ReadLine ( ) ) ;  //8

            Console.WriteLine ( " Lab2 : " ) ;​
            lab2 = double . Parse ( Console . ReadLine ( ) ) ;  //9

            Console . WriteLine ( " Parcial 1: " ) ;
            parcial1 = double . Parse ( Console . ReadLine ( ) ) ;  //7

            double c2 = lab1 * 30 / 100 + lab2 * 30 / 100 + parcial1 * 40 / 100 ;
            Console . WriteLine ( " La nota de C2 es: {0} " , c2 ) ;

            //Pausa.
            Console .ReadLine ( ) ;
        }
    }
}
