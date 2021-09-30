using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treinamentoCOTIN
{
    class elseif
    {
        public static void elif()
        {
            int notaALuno;
            Console.WriteLine("Insira a nota do aluno: ");
            notaALuno = int.Parse(Console.ReadLine());

            if (notaALuno >= 9)
            {
                Console.WriteLine("A");
            }
            else if (notaALuno >= 8)
            {
                Console.WriteLine("B");
            }
            else if (notaALuno >= 7)
            {
                Console.WriteLine("C");
            }
            else if (notaALuno >= 6)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }
        }
    }
}
