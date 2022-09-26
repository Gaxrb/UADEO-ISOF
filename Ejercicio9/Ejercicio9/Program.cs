using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float cms; // declaramos la variable centimetros

            Console.Write("Ingrese centimetros:");
            cms = float.Parse(Console.ReadLine()); // usamos parse para convertir nuestra respuesta a un numero

            Console.Write("{0} cenimetros es = {1} pies = {2} pulgadas", cms, (0.0328084 * cms), (0.393701 * cms)); //*Colocamos {} para luego asignarles el valor que son cm
                                                                                                                    //Y las dos formulas para convertir a pies y a pulgadas
            Console.Read();
        }
    }
}
