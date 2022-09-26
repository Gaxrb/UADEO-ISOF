using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args) // Una variable contadora es cuando se le suma un valor fijo, una variable acumuladora es cuando se le va sumando variables
        { // Ejemplo i++ o i=i+1 son variables contadoras /// suma = summa+i o suma+=i son variables acumuladoras
            int i = 0; // variable contadora
            float num,acu =0; // el num es el valor que ingresaremos y la variable acu sera lo acumulado entre los 5 numeros

            while (i < 5) // Seguira hasta el quinto ciclo // While sirve para 
            {
                Console.Write("Ingrese el {0}º número:", i + 1 ); // Lo que se ponga fuera de las comillas aparecera dentro de las llaves {}
                num = float.Parse(Console.ReadLine());
                acu += num; // Sumara cada numero que le ingresemos
                i++; // Servirá como nuestro contador de ciclos
            }
            Console.Write("El promedio de los 5 números es {0}", acu / 5); // nos mandara un mensaje y se hara la operacion de lo acumulado entre 5 colocandolo entre los {}
            Console.Read();


        }
    }
}
