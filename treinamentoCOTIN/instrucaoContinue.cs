using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treinamentoCOTIN
{
    class instrucaoContinue
    {
        public static void InstrucaoContinue()
        {
            string saida = "'";
            int contador;

            for (contador = 1; contador <= 10; contador++)
            {
                if (contador == 3)
                    continue;
                saida += contador + "";
            }
            saida += "\nUsando a instrução Continue para avançar um laço" + contador;

            Console.WriteLine(saida);
        }
    }
}
