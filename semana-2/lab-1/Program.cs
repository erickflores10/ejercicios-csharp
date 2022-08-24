using System;

namespace lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n_hamb, n_bebidas, n_papas;
            double precio_h, precio_b, precio_p, total;

            Console.Write("Cantidad de hamburguesas: ");
            n_hamb = byte.Parse(Console.ReadLine());

            Console.Write("Cantidad de papas: ");
            n_papas = byte.Parse(Console.ReadLine());

            Console.Write("Cantidad de bebidas: ");
            n_bebidas = byte.Parse(Console.ReadLine());

            precio_b = n_bebidas * 0.8;
            precio_h = n_hamb * 2;
            precio_p = n_papas * 1.2;

            total = precio_p + precio_h + precio_b;

            Console.WriteLine("\n" + "El precio a pagar es S/. " + total);
        }
    }
}
