using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treinamentoCOTIN
{
    class modulos
    {
        public static void Modulos()
        {
            string digitos;
            int divi1, quoc1, rest1, quoc2, rest2, quoc3, rest3, quoc4, quoc5;

            Console.WriteLine("Por favor informe o número: ");
            digitos = Console.ReadLine();

            divi1 = int.Parse(digitos);

            quoc1 = (divi1 / 10000);
            rest1 = (divi1 % 10000);
            quoc2 = (rest1 / 1000);
            rest2 = (rest1 % 1000);
            quoc3 = (rest2 / 100);
            rest3 = (rest2 % 100);
            quoc4 = (rest3 / 10);
            quoc5 = (rest3 % 10);

            if (divi1 >= 10000 && divi1 < 100000)
            {
                Console.WriteLine("Você informou a quantidade correta de digitos");
                Console.WriteLine();
                Console.Write("O numero informado foi: {0}", quoc1 + " ");
                Console.Write("{0}", quoc2 + " ");
                Console.Write("{0}", quoc4 + " ");
                Console.Write("{0}", quoc3 + " ");
                Console.WriteLine("{0}", quoc5 + "");
            }
            else
            {
                Console.WriteLine("Você não informou a quantidade de digitos correta.");
            }
        }
    }
}
