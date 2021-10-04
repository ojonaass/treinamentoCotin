using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO1
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo[] veiculo = new Veiculo[2];

            veiculo[0] = new Automovel("Ferrari");
            veiculo[1] = new Aeronave("Tucano");

            MovimentarVeiculo(veiculo[0]);
            MovimentarVeiculo(veiculo[1]);
        }

        public static void MovimentarVeiculo(Veiculo veiculo)
        {
            Console.WriteLine(veiculo.Tipo);
            veiculo.Mover();
        }
    }
}
