using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treinamentoCOTIN
{
    class concatenacao
    {
        public static void Concatena()
        {
            string nome, sobrenome, nomeCompleto;

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite seu sobrenome: ");
            sobrenome = Console.ReadLine();

            nomeCompleto = (nome + " " + sobrenome);

            Console.WriteLine("O nome digitado foi: {0}", nomeCompleto);
        }
    }
}
