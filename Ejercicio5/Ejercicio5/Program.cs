using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float bas, alt; // Declaramos las variables base y altura // bas = base / alt = altura
            Console.WriteLine("Ingrese base:"); // Solicitamos que se escriba un valor
            bas = float.Parse(Console.ReadLine()); // Convertimos el texto a numero y se lo asignamos a la variable base
            Console.WriteLine("Ingrese altura: ");
            alt = float.Parse(Console.ReadLine()); // lo mismo que en lo anterior pero ahora para la variable altura

            Console.WriteLine("El area del trinagulo es {0}", (bas * alt) / 2); // Utilizamos la formula del area del triangulo que es base por altura entre dos.
            Console.ReadLine();
        }
    }
}
