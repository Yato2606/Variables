using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string edad;
            Console.WriteLine("Escribe tu nombre: ");
            nombre=Console.ReadLine();
            Console.WriteLine("Escribe tu edad: ");
            edad = Console.ReadLine();
            Console.WriteLine("Nombre: "+nombre+ " Edad: " + edad);
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
