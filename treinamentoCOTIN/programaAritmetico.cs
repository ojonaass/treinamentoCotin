using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treinamentoCOTIN
{
    class programaAritmetico
    {
        public static void ProgramaAritmetico()
        {
            double n1, n2, n3, n4, soma, subtra, multi, divis, mod, expressao;

            Console.WriteLine("Insira o primeiro valor: ");
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo valor: ");
            n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o terceiro valor: ");
            n3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o quarto valor: ");
            n4 = double.Parse(Console.ReadLine());

            soma = n1 + n2;
            subtra = n3 - n2;
            multi = n4 * n1;
            divis = n3 / n4;
            mod = n3 % n2;
            expressao = (n1 + n2 / n3 + n4 - n1);

            Console.WriteLine("O resultado das operações foi: {0}, {1}, {2}, {3}, {4}, {5}", soma, subtra, multi, divis, mod, expressao);
            Console.ReadKey();
        }
    }
}
