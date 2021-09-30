using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treinamentoCOTIN
{
    class blocoTryFinally
    {
        public static void BlocoTryFinally()
        {
            try
            {
                throw new Exception("A excessão...");
            }
            finally
            {
                Console.WriteLine("O bloco finally é sempre executado...");
            }
        }
    }
}


