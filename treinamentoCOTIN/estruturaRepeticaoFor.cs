using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treinamentoCOTIN
{
    class estruturaRepeticaoFor
    {
        public static void erf()
        {
            int x, y;

            x = 1;
            y = 1;

            for (int j = x; j <= 32 * x * y; j += y / x)
            {
                Console.WriteLine(j);
            }
        }
    }
}
