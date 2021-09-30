using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treinamentoCOTIN
{
    class instrucaoThrow
    {
        public static void InstrucaoThrow(string[]args)
        {
            if (args.Length == 1)
            {
                Console.WriteLine(args[0]);
            }
            else
            {
                ArgumentOutOfRangeException ex;
                ex = new ArgumentOutOfRangeException("Utilize uma stringsomente!");
                throw (ex);
            }
        }
    }
}
