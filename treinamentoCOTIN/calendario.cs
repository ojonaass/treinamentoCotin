using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treinamentoCOTIN
{
    class calendario
    {
        public static void Calendario()
        {
            int ano = 2021;
            int mes = 1;


            Console.WriteLine();

            int[,] matrizCalendario = new int[6, 7];

            string[] diasSemana = new string[7] { "\t  D", "\t  S\t", "  T\t", "  Q\t", "  Q\t", "  S\t", "  S\t" };

            while (mes <= 12)
            {
                Console.WriteLine("Mês: " + mes);
                Console.WriteLine(diasSemana[0] + diasSemana[1] + diasSemana[2] + diasSemana[3] + diasSemana[4] + diasSemana[5] + diasSemana[6]);
                Console.WriteLine();
                calendarioMatriz(mes, ano);
                Console.WriteLine("\n-----------------------------------------------------------------\n");
                mes++;
            }

        }
        public static void calendarioMatriz(int mes, int ano)
        {
            int dia = 1;
            DateTime d = new DateTime(ano, mes, 1);
            int diaInicial = 1;
            var hoje = (int)d.DayOfWeek;
            int quantidadeDeDias = DateTime.DaysInMonth(ano, mes);
            int[,] matrizCalendario = new int[6, 7];

            for (int i = 0; i < matrizCalendario.GetLength(0); i++)
            {
                for (int j = 0; j < matrizCalendario.GetLength(1) && diaInicial - hoje <= quantidadeDeDias; j++)
                {

                    if (dia <= quantidadeDeDias)
                    {
                        var valor = diaInicial - hoje;
                        matrizCalendario[i, j] = valor;
                        if (matrizCalendario[i, j] > 0)
                        {
                            Console.Write("\t| " + matrizCalendario[i, j] + " |");
                            diaInicial++;
                        }
                        else
                        {
                            Console.Write("\t");
                            diaInicial++;
                        }


                    }
                }
                Console.WriteLine();
            }
        }
    }
}