using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treinamentoCOTIN
{
    class @while
    {
        public static void While()
        {
            int produto;
            produto = 2;

            while (produto <= 20)
            {
                Console.WriteLine("Informe o Numero: ");
                produto = int.Parse(Console.ReadLine());
                produto = (produto * 2);
            }
            Console.WriteLine("\n O Produto é {0}", produto);
        }
    }
}
