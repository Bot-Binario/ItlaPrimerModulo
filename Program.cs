/* Diseñar un programa que solicite al usuario dos números y, si el primer número es más grande, 
 calcule y muestre su suma y resta. De lo contrario, calculará y mostrará su producto y cociente.. */

using System;

namespace ItlaPrimerModulo
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("ingresa tu primer valor numérico: ");
            int primerNum = int.Parse(Console.ReadLine());

            Console.WriteLine("ingresa tu segundo valor numérico: ");
            int segundoNum = int.Parse(Console.ReadLine());

            int primerResultado = primerNum + segundoNum;
            Console.WriteLine("La suma de los numeros es: " + primerResultado);

            int segundoResultado = primerNum - segundoNum;
            Console.WriteLine("La resta de los numeros es " + segundoResultado);    
            {
                // Se utiliza el metodo Math.Max para arrojar el valor mas grande
                Console.WriteLine(Math.Max(primerNum, segundoNum));
            }
        }

    }
}