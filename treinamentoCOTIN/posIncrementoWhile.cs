using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treinamentoCOTIN
{
    class posIncrementoWhile
    {
        public static void PosIncrementoWhile()
        {
            int x, soma;

            x = 1;
            soma = 0;

            while (x <= 10)
            {
                soma += x++;
            }

            Console.WriteLine();
            Console.WriteLine("\t\t\tA Soma é: " + soma);
        }
    }
}
