using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Calcular calc = new Calcular();
            Console.WriteLine("\nPolimorfismo com sobrecarga\n");
            Console.WriteLine("Somando 2 números...");
            Console.WriteLine(calc.Soma(45,43));
            Console.WriteLine("Somando 3 números...");
            Console.WriteLine(calc.Soma(45,43,100));
            Console.ReadKey();
        }
    }
}
