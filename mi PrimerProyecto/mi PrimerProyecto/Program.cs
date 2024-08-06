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


            bool comprobar = true ;
            Console . WriteLine ( " El valor es : {0} " , comprobar ) ;
            //prioridad de los operadores aritmeticos.
            //se pone el sufijo m para la división con decimales.
             decimal respuesta = 5 + 8 - 2 * 5 / 4m + 1; //14.75 valor incorrecto; 11.5 -> valor correcto
            Console . WriteLine ( " La respuesta es: {0} " , respuesta ) ;

            Console . WriteLine ( " Nombre: " ) ;
            string nombre = Console.ReadLine ( ) ;

            Console . WriteLine ( " Hola {0} bienvenido " , nombre ) ;

            DateTime fechaActual = new DateTime ( ) ;
            fechaActual = DateTime . Now ;
            Console . WriteLine ( " La fecha actal es: {0} " , fechaActual ) ;
            Console . WriteLine ( " La división de 5/4 es {0}  " , 5/4 ) ;

            //Pausa.
            Console .ReadLine ( ) ;
        }
    }
}
