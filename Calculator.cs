using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

/* Diseñar un programa que solicite al usuario dos números y, si el primer número es más grande, 
 calcule y muestre su suma y resta. De lo contrario, calculará y mostrará su producto y cociente.. */

//Pendiente agregar varias condiciones que, No acepten valores negativos, no acepten strings, y omita la operacion 1 si no se cuemple.

namespace ItlaPrimerModulo
{
    internal class Calculator
    {
        /* To create a Funtion we use public/private + the methods + Name of the Funtion + (declare type of variables) */
        public static void MostrarSuma_Resta(int A, int B)
        {
            int suma = A + B;
            int resta = A - B;
            Console.WriteLine("La suma de los números es: " + suma);
            Console.WriteLine("La resta de los números es: " + resta);
        }

        public static void MostrarProducto_Cociente(int A, int B)
        {
            int producto = A * B;
            Console.WriteLine("El producto de los números es: " + producto);

            if (B != 0)
            {
                int cociente = A / B;
                Console.WriteLine("El cociente de los números es: " + cociente);
            }
            else
            {
                Console.WriteLine("No se puede dividir por cero.");
            }
   
          
        }
    }    
}