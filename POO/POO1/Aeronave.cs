using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO1
{
    public class Aeronave : Veiculo
    {
        public Aeronave(string tipoVeiculo)
            : base(tipoVeiculo) { }

        public override void Mover()
        {
            Console.WriteLine("O Passarinho vai voar");
        }
        public override void Parar()
        {
            Console.WriteLine("O Passarinho pousou");
        }
    }
}
