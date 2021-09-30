using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treinamentoCOTIN
{
    class instrucaoBreak
    {
        public static void InstrucaoBreak()
        {
            string saida = "'";
            int contador;

            for(contador = 1; contador <= 10; contador++)
            {
                if (contador == 7)
                    break;
                saida += contador + "";
            }
            saida += "\nINterrompe o laço quando o contador for igual a = " + contador;

            Console.WriteLine(saida);
        }
    }
}
