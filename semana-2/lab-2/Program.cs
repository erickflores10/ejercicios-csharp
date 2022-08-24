using System;

namespace lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte num_1, num_2;

            Console.Write("Primer numero: ");
            num_1 = byte.Parse(Console.ReadLine());

            Console.Write("Segundo numero: ");
            num_2 = byte.Parse(Console.ReadLine());

            if (num_1 > num_2)
            {
                Console.WriteLine("El numero " + num_1 + " es mayor que " + num_2);
            } else
            {
                Console.WriteLine("El numero " + num_2 + " es mayor que " + num_1);
            }
        }
    }
}
