using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num; // declaramos la variable numero
            Console.WriteLine("Ingrese un numero: ");
            num = float.Parse(Console.ReadLine()); // el parse convertira nuestra respuesta que era un texto a una variable numerica
            while (num < 1) // mientras que el numero sea menor que 1 se ejecutara la siguiente linea de codigo 
            { 
                Console.WriteLine("Error. Reingrese un numero: ");
                num = float.Parse(Console.ReadLine());
            }
            Console.WriteLine("El cuadrado de {0} es {1}: ",num ,(num * num)); // se realizara la formula para sacar el cuadrado y se pondra dentro de los {}
            Console.Read();
        }
    }
}
