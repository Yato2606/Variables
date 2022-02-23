using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enteros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero_1 = 3, numero_2 = 4, numero_3 = 5;

            int suma= numero_1 + numero_2 + numero_3;

            Console.WriteLine("El valor de SUMA es: " +suma);

            Console.WriteLine("Presiona cualquier tecla para continuar...");

            Console.ReadKey();

        }
    }
}
