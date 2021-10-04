using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO1
{
    public class Automovel : Aeronave
    {
        public Automovel(string tipoVeiculo)
            : base(tipoVeiculo) { }

        public override void Mover()
        {
            Console.WriteLine("Acelerando o veículo!");
        }

        public override void Parar()
        {
            Console.WriteLine("Parando o veículo!");
        }
    }
}
