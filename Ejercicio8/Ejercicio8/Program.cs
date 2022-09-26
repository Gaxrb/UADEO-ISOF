using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float celsius; // Declaramos la variable celcius

            Console.Write("Ingrese grados Celsius:");
            celsius = float.Parse(Console.ReadLine()); // utilizamos parse para convertir nuestra respuesta (que es un texto) a un numero

            Console.Write("{0} grados Celsius equivale a {1} grado Fahrenheit", celsius, (celsius * 2.12)); //*lo que esta despues de las "" sirve para colocarse dentro de {0} y {1}
                                                                                                            //Se colocaran en orden a como los introducimos, siendo separados por la coma.

            Console.Read();
        }
    }
}
