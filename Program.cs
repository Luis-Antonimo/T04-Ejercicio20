using System;

namespace T04Ejercicio20
{
    class Program
    {
        static void Main()
        {
            int sumVentas = 0;
            Console.WriteLine("Díga el número de ventas: ");
            int numVentas = Convert.ToInt32(Console.ReadLine());
            for (int x=1;x<=numVentas;x++)
            {
                Console.WriteLine("Indique el valor de la venta " + x + " :");
                int valorVenta = Convert.ToInt32(Console.ReadLine());
                sumVentas = sumVentas + valorVenta;
            }
            Console.WriteLine("La suma de todas las ventas es: " + sumVentas);
        }
    }
}

