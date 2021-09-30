using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treinamentoCOTIN
{
    class operadorLogico
    {
        public static void OperadorLogico()
        {
            Console.WriteLine("Operador Logico AND (&)" +
                "\n\n\tfalse & false: " + (false & false) +
                "\n\tfalse & true: " + (false & true) +
                "\n\ttrue  & false: " + (true & false) +
                "\n\ttrue  & true" + (true & true));
            Console.WriteLine("");

            Console.WriteLine("Operador Logico OR (|)" +
                "\n\n\tfalse | false: " + (false | false) +
                "\n\tfalse | true: " + (false | true) +
                "\n\ttrue  | false: " + (true | false) +
                "\n\ttrue  | true: " + (true | true));

            Console.WriteLine("Operador Lógico exclusivo OR (^)" +
                "\n\n\tfalse ^ false: " + (false ^ false) +
                "\n\tfalse ^ true: " + (false ^ true) +
                "\n\ttrue  ^ false: " + (true ^ false) +
                "\n\ttrue  ^ true: " + (true ^ true));

            Console.WriteLine("Operador Lógico NOT (!)" +
                "\n\t!false: " + (!false) + "\n\t!true: " + (!true));


            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
