using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treinamentoCOTIN
{
    class whileSentinela
    {
        public static void WhileSentinela()
        {
            int total, notaContador, nota;
            double media;

            total = 0;
            notaContador = 0;
            Console.WriteLine("Entre com uma nota, -1 para Sair: ");
            nota = int.Parse(Console.ReadLine());

            while (nota != -1)
            {
                total = total + nota;
                notaContador = notaContador++;

                Console.Write("Entre com uma nota, -1 para Sair: ");
                nota = int.Parse(Console.ReadLine());

            }
            if (notaContador != 0)
            {
                media = ((double)total / notaContador);

                Console.WriteLine("\nClasse com média igual a {0}", media);
            }
            else
            {
                Console.WriteLine("Nenhuma nota foi fornecida!");
            }
        }
    }
}
