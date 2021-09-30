using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treinamentoCOTIN
{
    class operadorCondicional
    {
        public static void OperadorCondicional()
        {
            Console.WriteLine("Conditional AND (&&)" +
                "\n\n\tfalse && false: " + (false && false) +
                "\n\tfalse && true: " + (false && true) +
                "\n\ttrue && false: " + (true && false) +
                 "\n\ttrue && true: " + (true && true));

            Console.WriteLine();
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Conditional OR (||)" +
                "\n\n\tfalse || false: " + (false || false) +
                "\n\tfalse || true: " + (false || true) +
                "\n\ttrue || false: " + (true || false) +
                "\n\ttrue || true: " + (true || true));


            Console.WriteLine();
            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
