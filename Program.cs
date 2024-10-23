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
            string? input1 = Console.ReadLine();
            int Primer_resultado = input1 != null ? int.Parse(input1 ) : 0;

            Console.WriteLine("ingresa tu segundo valor numérico: ");
            string? input2 = Console.ReadLine();
            int Segundo_resultado = input2 != null ? int.Parse(input2) : 0;

            Calculator.MostrarSuma_Resta(Primer_resultado, Segundo_resultado);

            Calculator.MostrarProducto_Cociente(Primer_resultado, Segundo_resultado);

        }

    }
}