using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treinamentoCOTIN
{
    class doWhile
    {
        public static void DoWhile()
        {
            int counter;

            counter = 1;

            do
            {
                Console.WriteLine(counter);
                counter++;
            } while (counter <= 5);
        }
    }
}
