using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] default_name = {"David", "david", "DAVID", "xd" };
            string name;

            Console.Write("Ingresa tu nombre: ");
            name = Console.ReadLine();

            Console.WriteLine("\n" + "-------------------------------" + "\n");

            if ((name == default_name[0] || name == default_name[1]) || name == default_name[2])
            {
                Console.WriteLine("Hola David");
            } else
            {
                Console.WriteLine("No te conozco.");
            }

            Console.ReadKey(true);
        }
    }
}
