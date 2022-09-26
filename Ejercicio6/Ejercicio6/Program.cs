using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num; // Declaramos la variable num
            Console.WriteLine("Ingrese un numero:");
            num = float.Parse(Console.ReadLine()); // Le asignamos el valor a num convirtiendo el texto anterior en un numero

            if (num == 0) // Creamos una condicional para saber cuando el numero no es negativo ni positivo 
                Console.WriteLine("El numero {0} no es positivo ni negativo ya que es un cero", num);

            if (num > 0) // Creamos una condicional para saber cuando el numero es positivo 
                Console.WriteLine("El numero {0} es positivo", num);

            if (num < 0) // Creamos una condicional para saber cuando el numero es negativo 
                Console.WriteLine("El numero {0} es negativo", num);

            Console.Read();
        }
    }
}
