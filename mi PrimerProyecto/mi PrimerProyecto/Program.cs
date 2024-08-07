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


            //estructuras de control.
            //1. si. ejercicio. pedir al usuario la edad si es mayor de edad que le diga bienvenido.
            Console . Write ( " Edad: " ) ;
            int edad = int . Parse ( Console.ReadLine ( ) ) ;

            if ( edad >= 18 ) {
                Console.WriteLine(" Bienvenido al mundo de las responsabilidades. ");
            } else {
                Console.WriteLine(" Eres un adolescente, disfruta de la vida. ");
            }
           
            //Pausa.
            Console .ReadLine ( ) ;
        }
    }
}
