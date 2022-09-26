using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num; // nombramos la variable num
            Console.WriteLine("Ingrese un numero: ");
            num = float.Parse(Console.ReadLine()); // le asignamos un valor

            while (num == 0) // ponemos una condicion (while = mientras)
            {
                Console.WriteLine("Reingrese el numero: ");
                num = float.Parse(Console.ReadLine());

            }

            if (num % 2 == 0) //Ponemos la condicion if (si) para determinar si se cumple //*
                              //utilizamos un condicional con una formula que significa que si el numero se puede dividir en dos es un par
                Console.WriteLine("El {0} es par", num);

            else // si no se cumple la condicion anterior se ejecutara la siguiente linea de codigo
                Console.WriteLine("El {0} es impar", num);

            Console.Read();



        }
    }
}
