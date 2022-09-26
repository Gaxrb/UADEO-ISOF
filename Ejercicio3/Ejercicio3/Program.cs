using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numero; // declaramos la variable numero
            uint cont = 0, menor = 0, mayor = 0; //declaramos la variable cont, menor y mayor, como solo pueden ser numeros positivos utilizamos uint

            while (cont < 10) // mientras el contador sea menor que 10 esta parte del codig se ejecutara en bucle
            {
                Console.WriteLine("Ingrese un numero: ");
                numero = float.Parse(Console.ReadLine());

                if (numero > 0) // si el numero es mayor a 0
                {
                    mayor++; // se le sumara 1 al valor de mayor
                }
                if (numero < 0) // si el numero es menor a 0
                {
                    menor++; // se le sumara 1 al valor de menor
                }

                cont++; // se suma 1 a la variable contador para que pare cuando llegue a un determinado valor
            }
            Console.WriteLine("Fueron {0} numeros mayores y {1} numeros menores", mayor, menor); // a los {} se les asignara el valor que son los que estan fuera de las "" 
                                                                                                   
            Console.Read();
        }
    }
}
