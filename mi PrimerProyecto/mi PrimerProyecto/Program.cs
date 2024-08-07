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


            //prioridad de los operadores aritméticos.
            // se pone el sufilo m para la division con decimales .
             decimal respuesta = 5 + 8 - 2 * 5 / 4m + 1; //14.75 valor incorrecto; 11.5 -> valor correcto
            Console . WriteLine ( " La respuesta es: {0} " , respuesta ) ;
            // ejercicio de obtener la nota final de la materia de programacion I .
            Console.WriteLine ( " Lab1 : " ) ;
            double lab1 = double . Parse ( Console . ReadLine ( ) ) ; //8

            Console.WriteLine ( " Lab2 : " ) ;
            double lab2 = double . Parse ( Console . ReadLine ( ) ) ; //9

            Console . WriteLine ( " La división de 5/4 es {0} " , 5/4 ) ;
            Console . WriteLine ( " parcial 1: " ) ;
            double parcial1 = double . Parse ( Console.ReadLine ( ) ) ; //7

            // 8*30%= 2,4
            // 9*30%= 2,7
            // 7*40%= 2,8
            //C1 = 7,9

            double c1 = lab1 * 30 / 100 + lab2 * 30 / 100 + parcial1 * 40 / 100 ;
            Console . WriteLine ( " La nota de c1 es: {0} " , c1 ) ;
            //Pausa.
            Console .ReadLine ( ) ;
        }
    }
}
