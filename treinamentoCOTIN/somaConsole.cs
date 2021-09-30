using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treinamentoCOTIN
{
    class somaConsole
    {
        public static void SomaConsole()
        {
            int numeroA, numeroB, soma;

            Console.WriteLine("Informe o primeiro numero: ");
            numeroA = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo numero: ");
            numeroB = int.Parse(Console.ReadLine());

            soma = numeroA + numeroB;

            Console.WriteLine("A soma é: {0}", soma);
            Console.ReadKey();
        }
    }
}
