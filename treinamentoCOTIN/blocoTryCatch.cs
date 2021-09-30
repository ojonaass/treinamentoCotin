using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treinamentoCOTIN
{
    class blocoTryCatch
    {
        public static void BlocoTryCatch()
        {
            int iMax = 0;

            Console.Write("Entre um inteiro para valor máximo, entre 0 e o máximo será sorteado");
            try
            {
                iMax = int.Parse(Console.ReadLine());
                Random r = new Random();
                int iRand = r.Next(1, iMax);
                Console.Write("O valor sorteado entre 1 e {1} é {0}", iRand, iMax);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("0 Não é um valor válido");
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
