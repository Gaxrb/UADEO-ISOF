using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float radio; // Estamos declarando la variable radio para trabajar con ella

            Console.WriteLine("ingresa el radio:");
            radio = float.Parse(Console.ReadLine()); // Convertimos el texto ingresado en la linea anterior a un numero 

            Console.WriteLine("El perimetro del circulo es {0}", (2 * 3.1416) * radio); // Calculamos el perimetro utilizando su formula
            Console.WriteLine("El area del ciculo es {0}", 3.1416 * (radio * radio)); // Aqui calculamos el area
            Console.ReadLine();
        }
    }
}
