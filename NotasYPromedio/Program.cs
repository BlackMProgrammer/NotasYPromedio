using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace NotasYPromedio
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] notas = new int[4];
            notas[0] = 90;
            notas[1] = 88;
            notas[2] = 92;
            notas[3] = 79;

            foreach (int nota in notas)
            {
                Console.WriteLine(nota);
            }

            int promedio = notas.Sum() / notas.Length;
            //promedio = promedio / notas.Length;

            Console.WriteLine("\nEl promedio es: {0}\n", promedio);

            //Ejercicio 3

            int[] ordenar = { 9, 15, 1, 14, 8, 7, 6, 5 };

            Array.Sort(ordenar);
            
            foreach (int numero in ordenar)
            {
                Console.WriteLine(numero);
            }

            int promedio2 = ordenar.Sum() / ordenar.Length;

            Console.WriteLine("\nEl promedio es: {0}\n", promedio2);

        }        
    }
}
