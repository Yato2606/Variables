using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoPerimetro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a=10, b=10, c=7;
            int p = a+b+c;
            Console.WriteLine("El perimetro del triangulo es: " +p);
            Console.WriteLine("Precione cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
