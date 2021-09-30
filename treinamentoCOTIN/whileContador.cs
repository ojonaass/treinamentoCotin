using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treinamentoCOTIN
{
    class whileContador
    {
        public static void WhileContador()
        {
            int total, notaContador, nota, mediaNotas;

            total = 0;
            notaContador = 1;

            while (notaContador <= 10)
            {
                Console.WriteLine("Informe a primeira nota: ");

                nota = int.Parse(Console.ReadLine());

                total = total + nota;

                notaContador = notaContador + 1;
            }
            mediaNotas = (total / 10);
            Console.WriteLine("A média da turma é {0}", mediaNotas);
        }
    }
}
