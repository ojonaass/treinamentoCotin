using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static POO.Veiculo;

namespace POO
{
    public class Carro : Veiculo
    {
        public Carro()
        {
            Console.WriteLine("Eu sou um carro!");
        }

        public override void Acelerar()
        {
            throw new NotImplementedException();
        }

        public override void Frear()
        {
            throw new NotImplementedException();
        }

        public override void Ligar()
        {
            InjetadoCombustivel = true;
            MotorLigado = true;
            Console.WriteLine("O Carro está ligado!");
        }
    }

}
