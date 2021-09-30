using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treinamentoCOTIN
{
    class estruturaDeControleIfElse
    {
        public static void edcie()
        {
            int notaAluno;

            Console.WriteLine("Digite a nota do Aluno: ");
            notaAluno = int.Parse(Console.ReadLine());

            if (notaAluno >= 7)
            {
                Console.WriteLine("O Aluno foi aprovado!");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
        }
    }
}
