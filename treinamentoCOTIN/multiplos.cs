using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treinamentoCOTIN
{
    class multiplos
    {
        public static void Multiplos()
        {
            int x, y, z;

            Console.WriteLine("Informe o primeiro número: ");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo número: ");
            y = int.Parse(Console.ReadLine());

            z = (x % y);

            if (z == 0)
            {
                Console.WriteLine("O 1º número é múltiplo do segundo");
            }
            else
            {
                Console.WriteLine("O 1º número não é múltiplo do segundo");
            }
        }
    }
}
