using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string letra; // declaramos la variable de texto letra
            uint a = 0, e = 0, i = 0, o = 0, u = 0; //*declaramos las vocales como variables numericas para que podamos contar
                                                    //cuantas veces aparecen en una oracion

            Console.Write("Ingrese una oracion:");
            letra = Console.ReadLine();
            for (int x = 0; x < 20; x++) //*es la variable que contara cuantas letras tiene nuestra oracion
                                         // el unico problema es que solo contara hasta la letra numero 20
            {
                if (letra[x] == 'a') // si se detecta una letra a
                    a++; // aumentara en uno su valor
                if (letra[x] == 'e') // si se detecta una letra e
                    e++; // aumentara en uno su valor
                if (letra[x] == 'i') // si se detecta una letra i
                    i++; // aumentara en uno su valor
                if (letra[x] == 'o') // si se detecta una letra o
                    o++; // aumentara en uno su valor
                if (letra[x] == 'u') // si se detecta una letra u
                    u++; // aumentara en uno su valor
            }
            Console.WriteLine("a = {0}, e = {1}, i = {2}, o = {3}, u = {4}", a, e, i, o, u); //apareceran dentro de los {} cuantas veces
                                                                                             //en la oracion aparecieron esas vocales
            Console.Read();
        }
    }
}
