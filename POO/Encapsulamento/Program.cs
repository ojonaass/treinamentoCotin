
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Retangulo();

            try
            {
                Console.WriteLine("Informe o comprimento: ");
                r.Comprimento = double.Parse(Console.ReadLine());
                Console.WriteLine("Informe a largura: ");
                r.Largura = double.Parse(Console.ReadLine());
                Console.WriteLine($"Area do retangulo: {r.GetArea()}");
            }
            catch (ArgumentException argEx)
            {
                Console.WriteLine($"Erro: {argEx}");
                throw;
            }

            _ = Console.ReadLine();
        }
    }
}
