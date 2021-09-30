using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treinamentoCOTIN
{
    class inicializaMenuApostila
    {
        public static void InicializaMenuApostila()
        {
            string iniciaApostila, comandoHelloWorld, comandoMultiplas;
            string quebraLinha ="\\n" ;
            string a = "____________________________________________________";

            welcome.Welcome();
            Console.WriteLine("Vamos começar? S/N");
            iniciaApostila = Console.ReadLine();

            if (iniciaApostila == "s")
            {
                Console.WriteLine("Certo, vamos começar com o básico.");
                Console.WriteLine(a);
                Console.WriteLine("Para imprimir um comando na tela digite: \n" +
                    "\"Console.WriteLine(\"Hello World\");\" Sem as aspas");
                Console.WriteLine(a);
                Console.WriteLine("Tente agora: ");
                comandoHelloWorld = Console.ReadLine();
                if(comandoHelloWorld == "Console.WriteLine(\"Hello World\");"){
                    hello.Hello();
                }
                else
                {
                    Console.WriteLine("Você digitou errado");
                }

                Console.WriteLine(a);
                Console.WriteLine("Agora que conseguiu escrever seu primeiro código em C#, vamos aumentar a dificuldade!");
                Console.WriteLine("\nVocê vai aprender a imprimir múltiplas telas com um unico código.\n");
                Console.WriteLine("Basta Digitar: " +
                    "\"Console.WriteLine(\"Bem{0}Vindo{0}Ao{0}C#\");\"", quebraLinha);
                Console.WriteLine("Tente agora: ");
                comandoMultiplas = Console.ReadLine();
                if (comandoMultiplas == "Console.WriteLine(\"Bem\\n\\nVindo\\nAoC#\");")
                {
                    Console.WriteLine("Está Correto");
                }

            }
            else
            {
                Console.WriteLine("Pressione qualquer tecla para sair...");
                Console.ReadKey();
            }
        }

    }
}
